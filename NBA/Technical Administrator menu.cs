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
    public partial class Technical_Administrator_menu : Form
    {
        public Technical_Administrator_menu()
        {
            InitializeComponent();
        }

        private void Technical_Administrator_menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form AdminMenu = new AdminMenu();
            AdminMenu.Show();
        }
    }
}
