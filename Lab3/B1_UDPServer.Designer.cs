using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class B1_UDPServer
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
            btnListen = new Button();
            txtPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtReceivedMessage = new TextBox();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListen.ForeColor = SystemColors.ActiveCaptionText;
            btnListen.Location = new Point(578, 38);
            btnListen.Margin = new Padding(4, 4, 4, 4);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(237, 93);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // txtPort
            // 
            txtPort.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPort.ForeColor = Color.DarkSlateGray;
            txtPort.Location = new Point(39, 65);
            txtPort.Margin = new Padding(4, 4, 4, 4);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(194, 39);
            txtPort.TabIndex = 2;
            txtPort.Text = "8080";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(46, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 41);
            label1.TabIndex = 3;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(44, 110);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(284, 41);
            label2.TabIndex = 4;
            label2.Text = "Received messages";
            // 
            // txtReceivedMessage
            // 
            txtReceivedMessage.BackColor = SystemColors.ControlLightLight;
            txtReceivedMessage.ForeColor = Color.DarkSlateGray;
            txtReceivedMessage.Location = new Point(39, 156);
            txtReceivedMessage.Margin = new Padding(4, 4, 4, 4);
            txtReceivedMessage.Multiline = true;
            txtReceivedMessage.Name = "txtReceivedMessage";
            txtReceivedMessage.ReadOnly = true;
            txtReceivedMessage.Size = new Size(775, 403);
            txtReceivedMessage.TabIndex = 1;
            // 
            // B1_UDPServer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 599);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPort);
            Controls.Add(txtReceivedMessage);
            Controls.Add(btnListen);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 4, 4, 4);
            Name = "B1_UDPServer";
            Text = "B1_UDPServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListen;
        private TextBox txtPort;
        private Label label1;
        private Label label2;
        private TextBox txtReceivedMessage;
    }
}