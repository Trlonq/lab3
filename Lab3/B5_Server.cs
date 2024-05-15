using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B5_Server : Form
    {
        private SQLiteConnection databaseConnection;
        private TcpListener serverListener;
        private Thread listenerThread;
        private List<TcpClient> connectedClients = new List<TcpClient>();
        private DataTable foodDataTable = new DataTable();
        private Random randomGenerator = new Random();
        public B5_Server()
        {
            InitializeComponent();
            InitializeDatabase();
            CreateTable();
            InitializeDataGridView();

        }


        private void InitializeDatabase()
        {
            string databaseName = $"food_db_{DateTime.Now:yyyyMMdd_HHmmss}.db";
            databaseConnection = new SQLiteConnection($"Data Source={databaseName};Version=3;New=True;Compress=True;");
            try
            {
                databaseConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening database connection: " + ex.Message);
            }
        }

        private void CreateTable()
        {
            string createTableSQL = @"CREATE TABLE IF NOT EXISTS Foods (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            food TEXT NOT NULL,
                            userName TEXT NOT NULL
                        );";

            SQLiteCommand createTableCommand = new SQLiteCommand(createTableSQL, databaseConnection);

            createTableCommand.ExecuteNonQuery();
        }

        private void StartFoodServer()
        {
            try
            {
                serverListener = new TcpListener(IPAddress.Any, 8888);
                serverListener.Start();
                listenerThread = new Thread(ListenForClients);
                listenerThread.IsBackground = true;
                listenerThread.Start();
                MessageBox.Show("Food server has started...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting food server: " + ex.Message);
            }
        }

        private void ListenForClients()
        {
            try
            {
                while (true)
                {
                    TcpClient client = serverListener.AcceptTcpClient();
                    connectedClients.Add(client);
                    Thread clientThread = new Thread(HandleClientCommunication);
                    clientThread.Start(client);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error listening for clients: " + ex.Message);
            }
        }

        private void HandleClientCommunication(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            byte[] message = new byte[4096];
            int bytesRead;

            try
            {
                Dictionary<string, Action<string[]>> requestHandlers = new Dictionary<string, Action<string[]>>
                {
                    { "add", dataParts => AddFoodToDatabase(dataParts[1], dataParts[2], ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString()) },
                    { "random", _ => ChooseRandomFood() }
                };

                while (true)
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                    if (bytesRead == 0)
                        break;

                    string clientData = Encoding.UTF8.GetString(message, 0, bytesRead);
                    string[] dataParts = clientData.Split(',');

                    if (requestHandlers.TryGetValue(dataParts[0], out var handler))
                        handler(dataParts);
                    else
                        MessageBox.Show("Invalid client request.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error handling client communication: " + ex.Message);
            }
            finally
            {
                connectedClients.Remove(tcpClient);
                tcpClient.Close();
            }
        }

        private void AddFoodToDatabase(string food, string userName, string ipAddress)
        {
            string addFoodSQL = "INSERT INTO Foods (food, userName) VALUES (@Food, @UserName)";

            SQLiteCommand addFoodCommand = new SQLiteCommand(addFoodSQL, databaseConnection);
            addFoodCommand.Parameters.AddWithValue("@Food", food);
            addFoodCommand.Parameters.AddWithValue("@UserName", userName);

            addFoodCommand.ExecuteNonQuery();

            DataRow newRow = foodDataTable.NewRow();
            newRow["ID"] = GetLastInsertedId();
            newRow["Food"] = food;
            newRow["UserName"] = userName;
            foodDataTable.Rows.Add(newRow);

            UpdateDataGridView();
        }

        private int GetLastInsertedId()
        {
            string query = "SELECT last_insert_rowid()";

            SQLiteCommand command = new SQLiteCommand(query, databaseConnection);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private void InitializeDataGridView()
        {
            dataGridView1.DataSource = foodDataTable;
            foodDataTable.Columns.Add("ID", typeof(int));
            foodDataTable.Columns.Add("Food", typeof(string));
            foodDataTable.Columns.Add("UserName", typeof(string));
        }

        private void UpdateDataGridView()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateDataGridView));
                return;
            }
            dataGridView1.Refresh();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartFoodServer();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            ChooseRandomFood();
        }

        private void ChooseRandomFood()
        {
            string message = foodDataTable.Rows.Count > 0 ? $"Random food: {GetRandomFood()}" : "No food available in the list.";
            MessageBox.Show(message, "Random Food");
        }

        private string GetRandomFood()
        {
            return foodDataTable.Rows.Count > 0 ? GetRandomFoodItem() : "";
        }

        private string GetRandomFoodItem()
        {
            int randomIndex = randomGenerator.Next(0, foodDataTable.Rows.Count);
            return foodDataTable.Rows[randomIndex]["Food"].ToString();
        }
    }
}
