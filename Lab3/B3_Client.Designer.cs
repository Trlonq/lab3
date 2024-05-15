using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class B3_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B3_Client));
            btn_Send = new Button();
            btn_Disconnect = new Button();
            btn_Connect = new Button();
            txt_Message = new TextBox();
            SuspendLayout();
            // 
            // btn_Send
            // 
            btn_Send.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Send.Location = new Point(340, 90);
            btn_Send.Margin = new Padding(5, 6, 5, 6);
            btn_Send.Name = "btn_Send";
            btn_Send.Size = new Size(159, 44);
            btn_Send.TabIndex = 0;
            btn_Send.Text = "Send message";
            btn_Send.UseVisualStyleBackColor = true;
            btn_Send.Click += btn_Send_Click;
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Disconnect.Location = new Point(340, 146);
            btn_Disconnect.Margin = new Padding(5, 6, 5, 6);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(159, 44);
            btn_Disconnect.TabIndex = 1;
            btn_Disconnect.Text = "Disconnect";
            btn_Disconnect.UseVisualStyleBackColor = true;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // btn_Connect
            // 
            btn_Connect.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Connect.Location = new Point(340, 34);
            btn_Connect.Margin = new Padding(5, 6, 5, 6);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(159, 44);
            btn_Connect.TabIndex = 2;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // txt_Message
            // 
            txt_Message.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_Message.Location = new Point(12, 12);
            txt_Message.Multiline = true;
            txt_Message.Name = "txt_Message";
            txt_Message.Size = new Size(320, 219);
            txt_Message.TabIndex = 3;
            // 
            // B3_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
           
            ClientSize = new Size(513, 254);
            Controls.Add(txt_Message);
            Controls.Add(btn_Connect);
            Controls.Add(btn_Disconnect);
            Controls.Add(btn_Send);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "B3_Client";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "B3_Client";
            FormClosing += frm_Client_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Send;
        private Button btn_Disconnect;
        private Button btn_Connect;
        private TextBox txt_Message;
    }
}