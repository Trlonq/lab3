using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class B1_UDPClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B1_UDPClient));
            btnSend = new Button();
            txtIP = new TextBox();
            txtPort = new TextBox();
            txtMessage = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.ForeColor = Color.DarkSlateGray;
            btnSend.Location = new Point(44, 493);
            btnSend.Margin = new Padding(4, 4, 4, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(146, 44);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtIP
            // 
            txtIP.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIP.ForeColor = Color.DarkSlateGray;
            txtIP.Location = new Point(43, 51);
            txtIP.Margin = new Padding(4, 4, 4, 4);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(194, 39);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            txtPort.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPort.ForeColor = Color.DarkSlateGray;
            txtPort.Location = new Point(552, 51);
            txtPort.Margin = new Padding(4, 4, 4, 4);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(194, 39);
            txtPort.TabIndex = 2;
            txtPort.Text = "8080";
            // 
            // txtMessage
            // 
            txtMessage.ForeColor = Color.DarkSlateGray;
            txtMessage.Location = new Point(43, 138);
            txtMessage.Margin = new Padding(4, 4, 4, 4);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(771, 328);
            txtMessage.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(43, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 32);
            label1.TabIndex = 4;
            label1.Text = "IP Remote host";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(552, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 32);
            label2.TabIndex = 5;
            label2.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(44, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 6;
            label3.Text = "Message";
            // 
            // B1_UDPClient
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 554);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMessage);
            Controls.Add(txtPort);
            Controls.Add(txtIP);
            Controls.Add(btnSend);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "B1_UDPClient";
            Text = "B1_UDPClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox txtIP;
        private TextBox txtPort;
        private TextBox txtMessage;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}