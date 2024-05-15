namespace Lab3
{
    partial class B6_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B6_Client));
            label3 = new Label();
            label2 = new Label();
            btnConnect = new Button();
            label1 = new Label();
            tenDangNhapTextBox = new TextBox();
            tinNhanTextBox = new TextBox();
            btnSend = new Button();
            trangThaiKetNoiLabel = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            chatRichTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 745);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 677);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 18;
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConnect.ForeColor = SystemColors.ActiveCaptionText;
            btnConnect.Location = new Point(723, 49);
            btnConnect.Margin = new Padding(5, 8, 5, 8);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(161, 56);
            btnConnect.TabIndex = 17;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(27, 55);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 16;
            label1.Text = "Nhập tên:";
            // 
            // tenDangNhapTextBox
            // 
            tenDangNhapTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tenDangNhapTextBox.ForeColor = Color.Sienna;
            tenDangNhapTextBox.Location = new Point(156, 54);
            tenDangNhapTextBox.Margin = new Padding(5, 8, 5, 8);
            tenDangNhapTextBox.Name = "tenDangNhapTextBox";
            tenDangNhapTextBox.Size = new Size(555, 39);
            tenDangNhapTextBox.TabIndex = 15;
            // 
            // tinNhanTextBox
            // 
            tinNhanTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tinNhanTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tinNhanTextBox.ForeColor = SystemColors.ActiveCaptionText;
            tinNhanTextBox.Location = new Point(29, 579);
            tinNhanTextBox.Margin = new Padding(5, 8, 5, 8);
            tinNhanTextBox.Name = "tinNhanTextBox";
            tinNhanTextBox.Size = new Size(666, 39);
            tinNhanTextBox.TabIndex = 14;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSend.ForeColor = SystemColors.ActiveCaptionText;
            btnSend.Location = new Point(723, 570);
            btnSend.Margin = new Padding(5, 8, 5, 8);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(161, 56);
            btnSend.TabIndex = 13;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // trangThaiKetNoiLabel
            // 
            trangThaiKetNoiLabel.AutoSize = true;
            trangThaiKetNoiLabel.BackColor = Color.Transparent;
            trangThaiKetNoiLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            trangThaiKetNoiLabel.ForeColor = SystemColors.ActiveCaptionText;
            trangThaiKetNoiLabel.Location = new Point(922, 582);
            trangThaiKetNoiLabel.Margin = new Padding(4, 0, 4, 0);
            trangThaiKetNoiLabel.Name = "trangThaiKetNoiLabel";
            trangThaiKetNoiLabel.Size = new Size(275, 32);
            trangThaiKetNoiLabel.TabIndex = 20;
            trangThaiKetNoiLabel.Text = "Status will display here";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            listBox1.ForeColor = SystemColors.ActiveCaptionText;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(922, 132);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(259, 420);
            listBox1.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(922, 59);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 32);
            label4.TabIndex = 22;
            label4.Text = "Thành viên:";
            // 
            // chatRichTextBox
            // 
            chatRichTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chatRichTextBox.ForeColor = SystemColors.ActiveCaptionText;
            chatRichTextBox.Location = new Point(34, 132);
            chatRichTextBox.Margin = new Padding(4);
            chatRichTextBox.Name = "chatRichTextBox";
            chatRichTextBox.ReadOnly = true;
            chatRichTextBox.Size = new Size(849, 420);
            chatRichTextBox.TabIndex = 23;
            chatRichTextBox.Text = "";
            // 
            // B6_Client
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 653);
            Controls.Add(chatRichTextBox);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(trangThaiKetNoiLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnConnect);
            Controls.Add(label1);
            Controls.Add(tenDangNhapTextBox);
            Controls.Add(tinNhanTextBox);
            Controls.Add(btnSend);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 8, 5, 8);
            Name = "B6_Client";
            Text = "B6_Client";
            Load += ClientForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tenDangNhapTextBox;
        private System.Windows.Forms.TextBox tinNhanTextBox;
        private System.Windows.Forms.Button btnSend;
        private Label trangThaiKetNoiLabel;
        private ListBox listBox1;
        private Label label4;
        private RichTextBox chatRichTextBox;
    }
}

