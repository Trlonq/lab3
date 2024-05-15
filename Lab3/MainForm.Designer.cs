using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bai1 = new Button();
            bai2 = new Button();
            bai3 = new Button();
            bai4 = new Button();
            bai5 = new Button();
            bai6 = new Button();
            SuspendLayout();
            // 
            // bai1
            // 
            bai1.BackColor = SystemColors.ButtonFace;
            bai1.FlatAppearance.BorderSize = 0;
            bai1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bai1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bai1.FlatStyle = FlatStyle.Flat;
            bai1.Location = new Point(50, 75);
            bai1.Margin = new Padding(4, 4, 4, 4);
            bai1.Name = "bai1";
            bai1.Size = new Size(302, 82);
            bai1.TabIndex = 0;
            bai1.Text = "Bài 1";
            bai1.UseVisualStyleBackColor = false;
            bai1.Click += bai1_Click;
            // 
            // bai2
            // 
            bai2.BackColor = SystemColors.ButtonFace;
            bai2.FlatAppearance.BorderSize = 0;
            bai2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bai2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bai2.FlatStyle = FlatStyle.Flat;
            bai2.Location = new Point(396, 79);
            bai2.Margin = new Padding(4, 4, 4, 4);
            bai2.Name = "bai2";
            bai2.Size = new Size(300, 78);
            bai2.TabIndex = 1;
            bai2.Text = "Bài 2";
            bai2.UseVisualStyleBackColor = false;
            bai2.Click += bai2_Click;
            // 
            // bai3
            // 
            bai3.BackColor = SystemColors.ButtonFace;
            bai3.FlatAppearance.BorderSize = 0;
            bai3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bai3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bai3.FlatStyle = FlatStyle.Flat;
            bai3.Location = new Point(741, 76);
            bai3.Margin = new Padding(4, 4, 4, 4);
            bai3.Name = "bai3";
            bai3.Size = new Size(298, 82);
            bai3.TabIndex = 2;
            bai3.Text = "Bài 3";
            bai3.UseVisualStyleBackColor = false;
            bai3.Click += bai3_Click;
            // 
            // bai4
            // 
            bai4.BackColor = SystemColors.ButtonFace;
            bai4.FlatAppearance.BorderSize = 0;
            bai4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bai4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bai4.FlatStyle = FlatStyle.Flat;
            bai4.Location = new Point(50, 199);
            bai4.Margin = new Padding(4, 4, 4, 4);
            bai4.Name = "bai4";
            bai4.Size = new Size(302, 82);
            bai4.TabIndex = 3;
            bai4.Text = "Bài 4";
            bai4.UseVisualStyleBackColor = false;
            bai4.Click += bai4_Click;
            // 
            // bai5
            // 
            bai5.BackColor = SystemColors.ButtonFace;
            bai5.FlatAppearance.BorderSize = 0;
            bai5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bai5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bai5.FlatStyle = FlatStyle.Flat;
            bai5.Location = new Point(396, 199);
            bai5.Margin = new Padding(4, 4, 4, 4);
            bai5.Name = "bai5";
            bai5.Size = new Size(300, 82);
            bai5.TabIndex = 4;
            bai5.Text = "Bài 5";
            bai5.UseVisualStyleBackColor = false;
            bai5.Click += bai5_Click;
            // 
            // bai6
            // 
            bai6.BackColor = SystemColors.ButtonFace;
            bai6.FlatAppearance.BorderSize = 0;
            bai6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bai6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bai6.FlatStyle = FlatStyle.Flat;
            bai6.Location = new Point(741, 199);
            bai6.Margin = new Padding(4, 4, 4, 4);
            bai6.Name = "bai6";
            bai6.Size = new Size(298, 82);
            bai6.TabIndex = 5;
            bai6.Text = "Bài 6";
            bai6.UseVisualStyleBackColor = false;
            bai6.Click += bai6_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1148, 360);
            Controls.Add(bai6);
            Controls.Add(bai5);
            Controls.Add(bai4);
            Controls.Add(bai3);
            Controls.Add(bai2);
            Controls.Add(bai1);
            ForeColor = SystemColors.ControlDarkDark;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "LAB03";
            ResumeLayout(false);
        }

        #endregion

        private Button bai1;
        private Button bai2;
        private Button bai3;
        private Button bai4;
        private Button bai5;
        private Button bai6;
    }
}