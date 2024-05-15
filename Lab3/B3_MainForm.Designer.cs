namespace Lab3
{
    partial class B3_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B3_MainForm));
            btn_Server = new Button();
            btn_Client = new Button();
            SuspendLayout();
            // 
            // btn_Server
            // 
            btn_Server.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Server.Location = new Point(22, 27);
            btn_Server.Margin = new Padding(5, 6, 5, 6);
            btn_Server.Name = "btn_Server";
            btn_Server.Size = new Size(348, 44);
            btn_Server.TabIndex = 0;
            btn_Server.Text = "Open TCP Server";
            btn_Server.UseVisualStyleBackColor = true;
            btn_Server.Click += btn_Server_Click;
            // 
            // btn_Client
            // 
            btn_Client.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Client.Location = new Point(22, 85);
            btn_Client.Margin = new Padding(5, 6, 5, 6);
            btn_Client.Name = "btn_Client";
            btn_Client.Size = new Size(348, 44);
            btn_Client.TabIndex = 1;
            btn_Client.Text = "Open new TCP Client";
            btn_Client.UseVisualStyleBackColor = true;
            btn_Client.Click += btn_Client_Click;
            // 
            // B3_MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
          
            ClientSize = new Size(390, 156);
            Controls.Add(btn_Client);
            Controls.Add(btn_Server);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "B3_MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "B3_MainForm";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_Server;
        private System.Windows.Forms.Button btn_Client;
    }
}
