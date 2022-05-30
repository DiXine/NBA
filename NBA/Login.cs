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
            this.loginField.AutoSize = false;
            this.loginField.Size = new Size(this.loginField.Size.Width, 32);

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 32);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AdminMenu = new AdminMenu();
            AdminMenu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form1 = new Form1();
            form1.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
