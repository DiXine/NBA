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
    public partial class addplayer : Form
    {
        public addplayer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form login = new Login();
            login.Show();
        }

        private void addplayer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.number = Convert.ToInt32(textBox1.Text);
            player.name = textBox2.Text;
            player.growth = Convert.ToInt32(textBox3.Text);
            player.position = Convert.ToInt32(textBox4.Text);
            player.college = textBox5.Text;
            player.country = textBox6.Text;
            player.price = Convert.ToInt32(textBox7.Text);
            player.TeamName = comboBox1.Text;


            for (int i = 0; i < Form1.teams.Length; i++)
                if (comboBox1.Text == Form1.teams[i].TeamName)
                    player.teamID = Form1.teams[i].teamID;

            Array.Resize(
                ref Form1.players, Form1.players.Length + 1);
            Form1.players[Form1.players.Length - 1] = player;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
