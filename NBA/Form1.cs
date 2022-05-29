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
        public static Player[] players = new Player[5];
        Position[] positions = new Position[5];
        public static Team[] teams = new Team[5];



        public Form1()
        {
            InitializeComponent();
            Country country = new Country();
            countries[0] = new Country();
            countries[0].set("ARG", "Argentina");
            countries[1] = new Country();           
            countries[1].set("BI", "Bosnia");
            countries[2] = new Country();
            countries[2].set("CA", "Canada");           
            countries[3] = new Country();
            countries[3].set("DE", "Germany");           
            countries[4] = new Country();
            countries[4].set("ES", "Spain");            


            Player player = new Player();
            players[0] = new Player();
            players[0].set(0,1, "Mo Williams", 185, 1, "college", "Argentina", 1500, "Miami Heat", 1);
            players[1] = new Player();
            players[1].set(1,2, "Alonzo Edward Gee", 198, 4, "college", "Bosnia", 1800, "Orlando Magic", 1);
            players[2] = new Player();
            players[2].set(2,3, "Johnny O'Bryant", 205, 3, "college", "Canada", 1600, "Atlanta Hawks", 1);
            players[3] = new Player();
            players[3].set(3,4, "Darrell Arthur", 206, 5, "college", "Germany", 1400, "Washington Wizards", 4);
            players[4] = new Player();
            players[4].set(4,5, "Jusuf Nurkic", 213, 2, "college", "Spain", 1200, "Charlotte Hornets", 1);
            

            Position position = new Position();
            positions[0] = new Position();
            positions[0].set("1", "SmallForward");
            positions[1] = new Position();
            positions[1].set("2", "PowerForward");
            positions[2] = new Position();
            positions[2].set("3", "Center");
            positions[3] = new Position();
            positions[3].set("4", "ShootingGuard");
            positions[4] = new Position();
            positions[4].set("5", "PointGuard");
            

            teams[0] = new Team();
            teams[0].set(1, "Miami Heat", "1", "MIA", "Erik Spoelstra", "AmericanAirlines Arena", "1.jpg");
            teams[1] = new Team();
            teams[1].set(2, "Orlando Magic", "1", "ORL", "Frank Vogel", "Amway Center", "2.jpg");
            teams[2] = new Team();
            teams[2].set(3, "Atlanta Hawks", "1", "ATL", "Mike Budenholzer", "Philips Arena", "3.jpg");
            teams[3] = new Team();
            teams[3].set(4, "Washington Wizards", "1", "WSH", "Scott Brooks", "Verizon Center", "4.jpg");
            teams[4] = new Team();
            teams[4].set(5, "Charlotte Hornets", "1", "CHA", "Steve Clifford", "Time Warner Cable Arena", "5.jpg");










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
