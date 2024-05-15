namespace Lab3
{
    partial class B3_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B3_Server));
            btn_Listen = new Button();
            lsv_Messages = new ListView();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // btn_Listen
            // 
            btn_Listen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Listen.Location = new Point(440, 25);
            btn_Listen.Margin = new Padding(5, 6, 5, 6);
            btn_Listen.Name = "btn_Listen";
            btn_Listen.Size = new Size(180, 44);
            btn_Listen.TabIndex = 0;
            btn_Listen.Text = "Listen";
            btn_Listen.UseVisualStyleBackColor = true;
            btn_Listen.Click += btn_Listen_Click;
            // 
            // lsv_Messages
            // 
            lsv_Messages.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            lsv_Messages.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lsv_Messages.HeaderStyle = ColumnHeaderStyle.None;
            lsv_Messages.Location = new Point(20, 83);
            lsv_Messages.Margin = new Padding(5, 6, 5, 6);
            lsv_Messages.Name = "lsv_Messages";
            lsv_Messages.Size = new Size(597, 392);
            lsv_Messages.TabIndex = 1;
            lsv_Messages.UseCompatibleStateImageBehavior = false;
            lsv_Messages.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 330;
            // 
            // B3_Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
     
            ClientSize = new Size(640, 502);
            Controls.Add(lsv_Messages);
            Controls.Add(btn_Listen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "B3_Server";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "B3_Server";
            FormClosing += frm_Server_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_Listen;
        private System.Windows.Forms.ListView lsv_Messages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}