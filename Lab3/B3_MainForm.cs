using Lab3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class B3_MainForm : Form
    {
        public B3_MainForm()
        {
            InitializeComponent();
        }
        private void btn_Server_Click(object sender, EventArgs e)
        {
            B3_Server a = new B3_Server();
            a.Show();
        }

        private void btn_Client_Click(object sender, EventArgs e)
        {
            B3_Client b = new B3_Client();
            b.Show();
        }
    }
}
