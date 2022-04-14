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
    public partial class Form1 : Form
    {
        String[] ImageList = new String[]
            {"photo1.jpg","photo2.jpg","photo3.jpg","photo4.jpg","photo5.jpg","photo6.jpg"};
        int index = 0;
        Country[] countries = new Country[5];
        Player[] players = new Player[5];
        Position[] positions = new Position[5];
        Team[] teams = new Team[6];
       


        public Form1()
        {
            InitializeComponent();
            Country country = new Country();
            country.set("ARG", "Argentina");
            countries[0] = country;
            country.set("BI", "Bosnia");
            countries[1] = country;
            country.set("CA", "Canada");
            countries[2] = country;
            country.set("DE", "Germany");
            countries[3] = country;
            country.set("ES", "Spain");
            countries[4] = country;

            Player player = new Player();
            player.set(1, "Mo Williams", 185, 1, "college", "Argentina", 1500);
            players[0] = player;
            player.set(2, "Alonzo Edward Gee", 198, 4, "college", "Bosnia", 1800);
            players[1] = player;
            player.set(3, "Johnny O'Bryant", 205, 3, "college", "Canada", 1600);
            players[2] = player;
            player.set(6, "Darrell Arthur", 206, 5, "college", "Germany", 1400);
            players[3] = player;
            player.set(5, "Jusuf Nurkic", 213, 2, "college", "Spain", 1200);
            players[4] = player;

            Position position = new Position();
            position.set("1", "SmallForward");
            positions[0] = position;
            position.set("2", "PowerForward");
            positions[1] = position;
            position.set("3", "Center");
            positions[2] = position;
            position.set("4", "ShootingGuard");
            positions[0] = position;
            position.set("5", "PointGuard");
            positions[0] = position;

            Team team = new Team();
            teams[0] = new Team();
            teams[0].set("1", "Miami Hea", "MIA", "1.jpg");
            teams[1] = new Team();
            teams[1].set("2", "Orlando Magic", "ORL", "2.jpg");
            teams[2] = new Team();
            teams[2].set("3", "Atlanta Hawks", "ATL", "3.jpg");
            teams[3] = new Team();
            teams[3].set("4", "Washington Wizards", "WSH", "4.jpg");
            teams[4] = new Team();
            teams[4].set("5", "Charlotte Hornets", "CHA", "5.jpg");
            teams[5] = new Team();
            teams[5].set("6", "Detroit Pistons", "DET", "6.jpg");
            


       





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("C:/Users/DiXine/Desktop/NBA/Photo/" + ImageList[0]);
            pictureBox2.Load("C:/Users/DiXine/Desktop/NBA/Photo/" + ImageList[1]);
            pictureBox3.Load("C:/Users/DiXine/Desktop/NBA/Photo/" + ImageList[2]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new Form2();
            form2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            index++;
            if (index > 3) index = 3;
            pictureBox1.Load("C:/Users/DiXine/Desktop/NBA/Photo/" + ImageList[index + 0]);
            pictureBox2.Load("C:/Users/DiXine/Desktop/NBA/Photo/" + ImageList[index + 1]);
            pictureBox3.Load("C:/Users/DiXine/Desktop/NBA/Photo/" + ImageList[index + 2]);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            index--;
            if (index < 1) index = 0;
            pictureBox1.Load("C:/Users/DiXine/Desktop/NBA/Photo/" + ImageList[index + 0]);
            pictureBox2.Load("C:/Users/DiXine/Desktop/NBA/Photo/" + ImageList[index + 1]);
            pictureBox3.Load("C:/Users/DiXine/Desktop/NBA/Photo/" + ImageList[index + 2]);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Login = new Login();
            Login.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
