using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class B5_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B5_MainForm));
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(50, 28);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(120, 36);
            button1.TabIndex = 0;
            button1.Text = "Server";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(192, 28);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(123, 36);
            button2.TabIndex = 1;
            button2.Text = "Client";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // B5_MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 98);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "B5_MainForm";
            Text = "B5_MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}