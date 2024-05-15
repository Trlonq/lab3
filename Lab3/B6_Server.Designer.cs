namespace Lab3
{
    partial class B6_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B6_Server));
            messageHistoryRichTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            messageTextBox = new TextBox();
            button1 = new Button();
            connectedClientsListBox = new ListBox();
            label3 = new Label();
            label4 = new Label();
            serverStatusLabel = new Label();
            SuspendLayout();
            // 
            // messageHistoryRichTextBox
            // 
            messageHistoryRichTextBox.BackColor = SystemColors.ControlLightLight;
            messageHistoryRichTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            messageHistoryRichTextBox.ForeColor = SystemColors.ActiveCaptionText;
            messageHistoryRichTextBox.Location = new Point(26, 92);
            messageHistoryRichTextBox.Margin = new Padding(5, 8, 5, 8);
            messageHistoryRichTextBox.Name = "messageHistoryRichTextBox";
            messageHistoryRichTextBox.ReadOnly = true;
            messageHistoryRichTextBox.Size = new Size(874, 360);
            messageHistoryRichTextBox.TabIndex = 0;
            messageHistoryRichTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 558);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 626);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 3;
            // 
            // messageTextBox
            // 
            messageTextBox.ForeColor = SystemColors.ActiveCaptionText;
            messageTextBox.Location = new Point(26, 476);
            messageTextBox.Margin = new Padding(5, 8, 5, 8);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(702, 39);
            messageTextBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(740, 468);
            button1.Margin = new Padding(5, 8, 5, 8);
            button1.Name = "button1";
            button1.Size = new Size(161, 56);
            button1.TabIndex = 5;
            button1.Text = "Gửi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += sendButton_Click;
            // 
            // connectedClientsListBox
            // 
            connectedClientsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            connectedClientsListBox.ForeColor = SystemColors.ActiveCaptionText;
            connectedClientsListBox.FormattingEnabled = true;
            connectedClientsListBox.Location = new Point(928, 92);
            connectedClientsListBox.Margin = new Padding(5, 8, 5, 8);
            connectedClientsListBox.Name = "connectedClientsListBox";
            connectedClientsListBox.SelectionMode = SelectionMode.MultiSimple;
            connectedClientsListBox.Size = new Size(255, 356);
            connectedClientsListBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(29, 52);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 29);
            label3.TabIndex = 7;
            label3.Text = "Tin nhắn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(928, 47);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(148, 29);
            label4.TabIndex = 8;
            label4.Text = "Thành viên:";
            // 
            // serverStatusLabel
            // 
            serverStatusLabel.AutoSize = true;
            serverStatusLabel.BackColor = Color.Transparent;
            serverStatusLabel.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serverStatusLabel.ForeColor = SystemColors.ActiveCaptionText;
            serverStatusLabel.Location = new Point(928, 484);
            serverStatusLabel.Margin = new Padding(4, 0, 4, 0);
            serverStatusLabel.Name = "serverStatusLabel";
            serverStatusLabel.Size = new Size(280, 29);
            serverStatusLabel.TabIndex = 9;
            serverStatusLabel.Text = "Status will display here";
            // 
            // B6_Server
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 600);
            Controls.Add(serverStatusLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(connectedClientsListBox);
            Controls.Add(button1);
            Controls.Add(messageTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(messageHistoryRichTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 8, 5, 8);
            Name = "B6_Server";
            Text = "B6_Server";
            Load += ServerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox messageHistoryRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox connectedClientsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Label serverStatusLabel;
    }
}

