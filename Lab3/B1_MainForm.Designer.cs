using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class B1_MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B1_MainForm));
            Server = new Button();
            Client = new Button();
            SuspendLayout();
            // 
            // Server
            // 
            Server.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Server.ForeColor = Color.DarkSlateGray;
            Server.Location = new Point(37, 47);
            Server.Name = "Server";
            Server.Size = new Size(200, 78);
            Server.TabIndex = 0;
            Server.Text = "UDP Server";
            Server.UseVisualStyleBackColor = true;
            Server.Click += Server_Click;
            // 
            // Client
            // 
            Client.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            Client.ForeColor = Color.DarkSlateGray;
            Client.Location = new Point(278, 47);
            Client.Name = "Client";
            Client.Size = new Size(202, 78);
            Client.TabIndex = 1;
            Client.Text = "UDP Client";
            Client.UseVisualStyleBackColor = true;
            Client.Click += Client_Click;
            // 
            // B1_MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
           
            ClientSize = new Size(514, 158);
            Controls.Add(Client);
            Controls.Add(Server);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "B1_MainForm";
            Text = "B1_MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button Server;
        private Button Client;
    }
}