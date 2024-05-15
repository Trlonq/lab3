using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class B5_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B5_Server));
            dataGridView1 = new DataGridView();
            listen = new Button();
            random = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 42);
            dataGridView1.Margin = new Padding(5, 5, 5, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(734, 301);
            dataGridView1.TabIndex = 0;
            // 
            // listen
            // 
            listen.Location = new Point(117, 394);
            listen.Margin = new Padding(5, 5, 5, 5);
            listen.Name = "listen";
            listen.Size = new Size(153, 46);
            listen.TabIndex = 1;
            listen.Text = "Listen";
            listen.UseVisualStyleBackColor = true;
            listen.Click += StartButton_Click;
            // 
            // random
            // 
            random.Location = new Point(530, 394);
            random.Margin = new Padding(5, 5, 5, 5);
            random.Name = "random";
            random.Size = new Size(153, 46);
            random.TabIndex = 7;
            random.Text = "Random";
            random.UseVisualStyleBackColor = true;
            random.Click += RandomButton_Click;
            // 
            // B5_Server
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 516);
            Controls.Add(random);
            Controls.Add(listen);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            Name = "B5_Server";
            Text = "B5_Server";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button listen;
        private Button random;
    }
}