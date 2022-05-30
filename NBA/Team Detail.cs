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
    public partial class Team_Detail : Form
    {
        Team teams = new Team();

        public int teamID = 0;
        public Team_Detail()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form teams = new Teams();
            teams.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Team_Detail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.teams.Length; i++)
                if (this.teamID == Form1.teams[i].teamID)
                    this.teams = Form1.teams[i];
            label3.Text = this.teams.TeamName;


            for (int i = 0; i < Form1.players.Length; i++)
                if (Form1.players[i].teamID == this.teamID)
                {
                    dataGridView1.Rows.Add
                        (Form1.players[i].playerID, 
                        Form1.players[i].number, 
                        Form1.players[i].name, 
                        Form1.players[i].growth, 
                        Form1.players[i].position,
                        Form1.players[i].college, 
                        Form1.players[i].country, 
                        Form1.players[i].price, 
                        Form1.players[i].TeamName, 
                        Form1.players[i].teamID);
                }
            
        }
    }
}
