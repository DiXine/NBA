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
    public partial class Manage_Seasons : Form
    {
        public Manage_Seasons()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Admin1 = new Admin1();
            Admin1.Show();
        }

        private void Manage_Seasons_Load(object sender, EventArgs e)
        {

        }
    }
}
