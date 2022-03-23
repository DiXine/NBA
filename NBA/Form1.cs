﻿using System;
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

        public Form1()
        {
            InitializeComponent();
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
