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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form admin1 = new Admin1();
            admin1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TechnicalAdministratormenu = new Technical_Administrator_menu();
            TechnicalAdministratormenu.Show();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
