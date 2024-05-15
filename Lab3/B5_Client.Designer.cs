using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class B5_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B5_Client));
            button1 = new Button();
            button2 = new Button();
            txtFood = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(172, 74);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 0;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(172, 216);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(118, 36);
            button2.TabIndex = 1;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtFood
            // 
            txtFood.Location = new Point(224, 162);
            txtFood.Margin = new Padding(4);
            txtFood.Name = "txtFood";
            txtFood.Size = new Size(176, 31);
            txtFood.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 162);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 5;
            label2.Text = "Nhập tên món ăn:";
            // 
            // txtName
            // 
            txtName.Location = new Point(245, 35);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 31);
            txtName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 8;
            label1.Text = "Nhập tên người dùng:";
            // 
            // B5_Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 292);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtFood);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "B5_Client";
            Text = "B5_Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtFood;
        private Label label2;
        private TextBox txtName;
        private Label label1;
    }
}