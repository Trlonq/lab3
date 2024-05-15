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
    public partial class B6_MainForm : Form
    {
        public B6_MainForm()
        {
            InitializeComponent();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            B6_Server a = new B6_Server();
            a.Show();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            B6_Client b = new B6_Client();
            b.Show();
        }
    }
}
