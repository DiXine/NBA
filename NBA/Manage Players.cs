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
    public partial class Manage_Players : Form
    {
        public Manage_Players()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Admin1 = new Admin1();
            Admin1.Show();
        }

        private void Manage_Players_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TeamReport = new Team_Report();
            TeamReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form addplayer = new addplayer();
            addplayer.Show();
        }
    }
}
