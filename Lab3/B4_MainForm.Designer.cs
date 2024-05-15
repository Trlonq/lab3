using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class B4_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B4_MainForm));
            comboBox1 = new ComboBox();
            label1 = new Label();
            A_1 = new CheckBox();
            label2 = new Label();
            A_2 = new CheckBox();
            A_3 = new CheckBox();
            A_4 = new CheckBox();
            A_5 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            B_1 = new CheckBox();
            B_2 = new CheckBox();
            B_3 = new CheckBox();
            B_4 = new CheckBox();
            B_5 = new CheckBox();
            C_1 = new CheckBox();
            C_2 = new CheckBox();
            C_3 = new CheckBox();
            C_4 = new CheckBox();
            C_5 = new CheckBox();
            datve = new Button();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            btnXuatThongTin = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Phim A", "Phim B", "Phim C", "Phim D" });
            comboBox1.Location = new Point(130, 20);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 1;
            label1.Text = "Chon Phim";
            // 
            // A_1
            // 
            A_1.AutoSize = true;
            A_1.CheckAlign = ContentAlignment.MiddleCenter;
            A_1.Location = new Point(120, 123);
            A_1.Margin = new Padding(4, 5, 4, 5);
            A_1.Name = "A_1";
            A_1.Size = new Size(26, 29);
            A_1.TabIndex = 2;
            A_1.Text = "1";
            A_1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 3;
            label2.Text = "A";
            // 
            // A_2
            // 
            A_2.AutoSize = true;
            A_2.CheckAlign = ContentAlignment.MiddleCenter;
            A_2.Location = new Point(153, 123);
            A_2.Margin = new Padding(4, 5, 4, 5);
            A_2.Name = "A_2";
            A_2.Size = new Size(26, 29);
            A_2.TabIndex = 2;
            A_2.Text = "2";
            A_2.UseVisualStyleBackColor = true;
            // 
            // A_3
            // 
            A_3.AutoSize = true;
            A_3.CheckAlign = ContentAlignment.MiddleCenter;
            A_3.Location = new Point(186, 123);
            A_3.Margin = new Padding(4, 5, 4, 5);
            A_3.Name = "A_3";
            A_3.Size = new Size(26, 29);
            A_3.TabIndex = 2;
            A_3.Text = "3";
            A_3.UseVisualStyleBackColor = true;
            // 
            // A_4
            // 
            A_4.AutoSize = true;
            A_4.CheckAlign = ContentAlignment.MiddleCenter;
            A_4.Location = new Point(219, 123);
            A_4.Margin = new Padding(4, 5, 4, 5);
            A_4.Name = "A_4";
            A_4.Size = new Size(26, 29);
            A_4.TabIndex = 2;
            A_4.Text = "4";
            A_4.UseVisualStyleBackColor = true;
            // 
            // A_5
            // 
            A_5.AutoSize = true;
            A_5.CheckAlign = ContentAlignment.MiddleCenter;
            A_5.Location = new Point(251, 123);
            A_5.Margin = new Padding(4, 5, 4, 5);
            A_5.Name = "A_5";
            A_5.Size = new Size(26, 29);
            A_5.TabIndex = 2;
            A_5.Text = "5";
            A_5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 167);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 3;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 208);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 3;
            label4.Text = "C";
            // 
            // B_1
            // 
            B_1.AutoSize = true;
            B_1.CheckAlign = ContentAlignment.MiddleCenter;
            B_1.Location = new Point(120, 160);
            B_1.Margin = new Padding(4, 5, 4, 5);
            B_1.Name = "B_1";
            B_1.Size = new Size(26, 29);
            B_1.TabIndex = 2;
            B_1.Text = "1";
            B_1.UseVisualStyleBackColor = true;
            // 
            // B_2
            // 
            B_2.AutoSize = true;
            B_2.CheckAlign = ContentAlignment.MiddleCenter;
            B_2.Location = new Point(153, 160);
            B_2.Margin = new Padding(4, 5, 4, 5);
            B_2.Name = "B_2";
            B_2.Size = new Size(26, 29);
            B_2.TabIndex = 2;
            B_2.Text = "2";
            B_2.UseVisualStyleBackColor = true;
            // 
            // B_3
            // 
            B_3.AutoSize = true;
            B_3.CheckAlign = ContentAlignment.MiddleCenter;
            B_3.Location = new Point(186, 160);
            B_3.Margin = new Padding(4, 5, 4, 5);
            B_3.Name = "B_3";
            B_3.Size = new Size(26, 29);
            B_3.TabIndex = 2;
            B_3.Text = "3";
            B_3.UseVisualStyleBackColor = true;
            // 
            // B_4
            // 
            B_4.AutoSize = true;
            B_4.CheckAlign = ContentAlignment.MiddleCenter;
            B_4.Location = new Point(219, 160);
            B_4.Margin = new Padding(4, 5, 4, 5);
            B_4.Name = "B_4";
            B_4.Size = new Size(26, 29);
            B_4.TabIndex = 2;
            B_4.Text = "4";
            B_4.UseVisualStyleBackColor = true;
            // 
            // B_5
            // 
            B_5.AutoSize = true;
            B_5.CheckAlign = ContentAlignment.MiddleCenter;
            B_5.Location = new Point(251, 160);
            B_5.Margin = new Padding(4, 5, 4, 5);
            B_5.Name = "B_5";
            B_5.Size = new Size(26, 29);
            B_5.TabIndex = 2;
            B_5.Text = "5";
            B_5.UseVisualStyleBackColor = true;
            // 
            // C_1
            // 
            C_1.AutoSize = true;
            C_1.CheckAlign = ContentAlignment.MiddleCenter;
            C_1.Location = new Point(120, 202);
            C_1.Margin = new Padding(4, 5, 4, 5);
            C_1.Name = "C_1";
            C_1.Size = new Size(26, 29);
            C_1.TabIndex = 2;
            C_1.Text = "1";
            C_1.UseVisualStyleBackColor = true;
            // 
            // C_2
            // 
            C_2.AutoSize = true;
            C_2.CheckAlign = ContentAlignment.MiddleCenter;
            C_2.Location = new Point(153, 202);
            C_2.Margin = new Padding(4, 5, 4, 5);
            C_2.Name = "C_2";
            C_2.Size = new Size(26, 29);
            C_2.TabIndex = 2;
            C_2.Text = "2";
            C_2.UseVisualStyleBackColor = true;
            // 
            // C_3
            // 
            C_3.AutoSize = true;
            C_3.CheckAlign = ContentAlignment.MiddleCenter;
            C_3.Location = new Point(186, 202);
            C_3.Margin = new Padding(4, 5, 4, 5);
            C_3.Name = "C_3";
            C_3.Size = new Size(26, 29);
            C_3.TabIndex = 2;
            C_3.Text = "3";
            C_3.UseVisualStyleBackColor = true;
            // 
            // C_4
            // 
            C_4.AutoSize = true;
            C_4.CheckAlign = ContentAlignment.MiddleCenter;
            C_4.Location = new Point(219, 202);
            C_4.Margin = new Padding(4, 5, 4, 5);
            C_4.Name = "C_4";
            C_4.Size = new Size(26, 29);
            C_4.TabIndex = 2;
            C_4.Text = "4";
            C_4.UseVisualStyleBackColor = true;
            // 
            // C_5
            // 
            C_5.AutoSize = true;
            C_5.CheckAlign = ContentAlignment.MiddleCenter;
            C_5.Location = new Point(251, 202);
            C_5.Margin = new Padding(4, 5, 4, 5);
            C_5.Name = "C_5";
            C_5.Size = new Size(26, 29);
            C_5.TabIndex = 2;
            C_5.Text = "5";
            C_5.UseVisualStyleBackColor = true;
            // 
            // datve
            // 
            datve.Location = new Point(17, 298);
            datve.Margin = new Padding(4, 5, 4, 5);
            datve.Name = "datve";
            datve.Size = new Size(314, 38);
            datve.TabIndex = 4;
            datve.Text = "Đặt vé";
            datve.UseVisualStyleBackColor = true;
            datve.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 268);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(130, 68);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(171, 33);
            comboBox2.TabIndex = 0;
            comboBox2.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 82);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 1;
            label6.Text = "Chon phong";
            // 
            // btnXuatThongTin
            // 
            btnXuatThongTin.Location = new Point(16, 346);
            btnXuatThongTin.Margin = new Padding(4, 5, 4, 5);
            btnXuatThongTin.Name = "btnXuatThongTin";
            btnXuatThongTin.Size = new Size(314, 38);
            btnXuatThongTin.TabIndex = 6;
            btnXuatThongTin.Text = "Xuất thông tin";
            btnXuatThongTin.UseVisualStyleBackColor = true;
            btnXuatThongTin.Click += btnXuatThongTin_Click;
            // 
            // B4_MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(349, 400);
            Controls.Add(btnXuatThongTin);
            Controls.Add(label5);
            Controls.Add(datve);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(C_5);
            Controls.Add(C_4);
            Controls.Add(B_5);
            Controls.Add(B_4);
            Controls.Add(C_3);
            Controls.Add(A_5);
            Controls.Add(B_3);
            Controls.Add(C_2);
            Controls.Add(A_4);
            Controls.Add(B_2);
            Controls.Add(C_1);
            Controls.Add(A_3);
            Controls.Add(B_1);
            Controls.Add(A_2);
            Controls.Add(A_1);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "B4_MainForm";
            Text = "B4_MainForm";
            Load += Bai5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private CheckBox A_1;
        private Label label2;
        private CheckBox A_2;
        private CheckBox A_3;
        private CheckBox A_4;
        private CheckBox A_5;
        private Label label3;
        private Label label4;
        private CheckBox B_1;
        private CheckBox B_2;
        private CheckBox B_3;
        private CheckBox B_4;
        private CheckBox B_5;
        private CheckBox C_1;
        private CheckBox C_2;
        private CheckBox C_3;
        private CheckBox C_4;
        private CheckBox C_5;
        private Button datve;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private Button button2;
        private Button btnXuatThongTin;
    }
}