using Lab3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B1_MainForm : Form
    {
        public B1_MainForm()
        {
            InitializeComponent();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            B1_UDPServer a = new B1_UDPServer();
            a.Show();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            B1_UDPClient b = new B1_UDPClient();
            b.Show();
        }
    }
}
