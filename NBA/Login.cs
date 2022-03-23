using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Admin1 = new Admin1();
            Admin1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
