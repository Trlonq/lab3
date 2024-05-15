using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class B6_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B6_MainForm));
            Server = new Button();
            Client = new Button();
            SuspendLayout();
            // 
            // Server
            // 
            Server.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Server.ForeColor = SystemColors.ActiveCaptionText;
            Server.Location = new Point(38, 56);
            Server.Margin = new Padding(4, 4, 4, 4);
            Server.Name = "Server";
            Server.Size = new Size(185, 88);
            Server.TabIndex = 0;
            Server.Text = "Server";
            Server.UseVisualStyleBackColor = true;
            Server.Click += Server_Click;
            // 
            // Client
            // 
            Client.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Client.ForeColor = SystemColors.ActiveCaptionText;
            Client.Location = new Point(290, 56);
            Client.Margin = new Padding(4, 4, 4, 4);
            Client.Name = "Client";
            Client.Size = new Size(183, 88);
            Client.TabIndex = 1;
            Client.Text = "Client";
            Client.UseVisualStyleBackColor = true;
            Client.Click += Client_Click;
            // 
            // B6_MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 211);
            Controls.Add(Client);
            Controls.Add(Server);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "B6_MainForm";
            Text = "B5_MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button Server;
        private Button Client;
    }
}