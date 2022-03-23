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
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void Admin1_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ManageSeasons = new Manage_Seasons();
            ManageSeasons.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ManageMatchups = new Manage_Matchups();
            ManageMatchups.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ManageTeams = new Manage_Teams();
            ManageTeams.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ManagePlayers = new Manage_Players();
            ManagePlayers.Show();

        }
    }
}
