using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3
{
    partial class B2_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B2_Server));
            Listen = new Button();
            listViewCommand = new ListView();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // Listen
            // 
            Listen.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Listen.ForeColor = Color.MidnightBlue;
            Listen.Location = new Point(417, 25);
            Listen.Margin = new Padding(5, 6, 5, 6);
            Listen.Name = "Listen";
            Listen.Size = new Size(203, 44);
            Listen.TabIndex = 0;
            Listen.Text = "Listen";
            Listen.UseVisualStyleBackColor = true;
            Listen.Click += Listen_Click;
            // 
            // listViewCommand
            // 
            listViewCommand.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewCommand.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listViewCommand.ForeColor = Color.MidnightBlue;
            listViewCommand.HeaderStyle = ColumnHeaderStyle.None;
            listViewCommand.Location = new Point(20, 83);
            listViewCommand.Margin = new Padding(5, 6, 5, 6);
            listViewCommand.Name = "listViewCommand";
            listViewCommand.Size = new Size(597, 392);
            listViewCommand.TabIndex = 1;
            listViewCommand.UseCompatibleStateImageBehavior = false;
            listViewCommand.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 330;
            // 
            // B2_Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
       
            ClientSize = new Size(640, 502);
            Controls.Add(listViewCommand);
            Controls.Add(Listen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "B2_Server";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "B2_Server";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Listen;
        private System.Windows.Forms.ListView listViewCommand;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

