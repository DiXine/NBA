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
    public partial class Teams : Form
    {
        public Teams()
        {
            InitializeComponent();
            this.Controls.Find("label3", true)[0].Text = Form1.teams[0].TeamName;
            this.Controls.Find("label4", true)[0].Text = Form1.teams[1].TeamName;
            this.Controls.Find("label5", true)[0].Text = Form1.teams[2].TeamName;
            this.Controls.Find("label6", true)[0].Text = Form1.teams[3].TeamName;
            this.Controls.Find("label7", true)[0].Text = Form1.teams[4].TeamName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabPage1.Visible = true ;
            tabPage2.Visible = false ;
        }

        private void Teams_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Team_Detail teamdetail = new Team_Detail();
            teamdetail.teamID = 1;
            teamdetail.Show();
        }
    }
}
