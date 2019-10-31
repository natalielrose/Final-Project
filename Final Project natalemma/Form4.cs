using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_natalemma
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int f = 0;
        int n = 0;
        int d = 0;
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                f++;
                label2.Text = "Who are you watching it with?";
                radioButton1.Text = "Siblings";
                radioButton2.Text = "Parents";
                radioButton3.Text = "Grandparents";
                radioButton4.Text = "Friends";
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked == true)
            {
                n++;
                label2.Text = "Who are you watching it with?";
                radioButton1.Text = "Siblings";
                radioButton2.Text = "Parents";
                radioButton3.Text = "Grandparents";
                radioButton4.Text = "Friends";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                d++;
                label2.Text = "Who are you watching it with?";
                radioButton1.Text = "Siblings";
                radioButton2.Text = "Parents";
                radioButton3.Text = "Grandparents";
                radioButton4.Text = "Friends";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                i++;
                label2.Text = "Who are you watching it with?";
                radioButton1.Text = "Siblings";
                radioButton2.Text = "Parents";
                radioButton3.Text = "Grandparents";
                radioButton4.Text = "Friends";
                radioButton4.Checked = false;
            }
            button2.Visible = false;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                f++;
                label2.Text = "What snack will you have?";
                radioButton1.Text = "Ice cream";
                radioButton2.Text = "Candy";
                radioButton3.Text = "Popcorn";
                radioButton4.Text = "Pizza";
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked == true)
            {
                n++;
                label2.Text = "What snack will you have?";
                radioButton1.Text = "Ice cream";
                radioButton2.Text = "Candy";
                radioButton3.Text = "Popcorn";
                radioButton4.Text = "Pizza";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                d++;
                label2.Text = "What snack will you have?";
                radioButton1.Text = "Ice cream";
                radioButton2.Text = "Candy";
                radioButton3.Text = "Popcorn";
                radioButton4.Text = "Pizza";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                i++;
                label2.Text = "What snack will you have?";
                radioButton1.Text = "Ice cream";
                radioButton2.Text = "Candy";
                radioButton3.Text = "Popcorn";
                radioButton4.Text = "Pizza";
                radioButton4.Checked = false;
            }
            button3.Visible = false;
            button4.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                f++;
                label2.Text = "What beverage will you have?";
                radioButton1.Text = "Smoothie";
                radioButton2.Text = "Water";
                radioButton3.Text = "Lemonade";
                radioButton4.Text = "Soda";
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked == true)
            {
                n++;
                label2.Text = "What beverage will you have?";
                radioButton1.Text = "Smoothie";
                radioButton2.Text = "Water";
                radioButton3.Text = "Lemonade";
                radioButton4.Text = "Soda";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                d++;
                label2.Text = "What beverage will you have?";
                radioButton1.Text = "Smoothie";
                radioButton2.Text = "Water";
                radioButton3.Text = "Lemonade";
                radioButton4.Text = "Soda";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                i++;
                label2.Text = "What beverage will you have?";
                radioButton1.Text = "Smoothie";
                radioButton2.Text = "Water";
                radioButton3.Text = "Lemonade";
                radioButton4.Text = "Soda";
                radioButton4.Checked = false;
            }
            button4.Visible = false;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                f++;
                label2.Text = "What's the weather like?";
                radioButton1.Text = "Snowing.";
                radioButton2.Text = "Cloudy.";
                radioButton3.Text = "Sunny.";
                radioButton4.Text = "Raining.";
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked == true)
            {
                n++;
                label2.Text = "What's the weather like?";
                radioButton1.Text = "Snowing.";
                radioButton2.Text = "Cloudy.";
                radioButton3.Text = "Sunny.";
                radioButton4.Text = "Raining.";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                d++;
                label2.Text = "What's the weather like?";
                radioButton1.Text = "Snowing.";
                radioButton2.Text = "Cloudy.";
                radioButton3.Text = "Sunny.";
                radioButton4.Text = "Raining.";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                i++;
                label2.Text = "What's the weather like?";
                radioButton1.Text = "Snowing.";
                radioButton2.Text = "Cloudy.";
                radioButton3.Text = "Sunny.";
                radioButton4.Text = "Raining.";
                radioButton4.Checked = false;
            }
            button5.Visible = false;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button7.Visible = true;
            if (radioButton1.Checked == true)
            {
                f++;
                label2.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }
            if (radioButton2.Checked == true)
            {
                n++;
                label2.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }
            if (radioButton3.Checked == true)
            {
                d++;
                label2.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
            }
            if (radioButton4.Checked == true)
            {
                i++;
                label2.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            if (f == 5 || f==4)
            {
                pictureBox2.Image = Properties.Resources.chilly;
            }
            if (n == 5 || n==4)
            {
                pictureBox2.Image = Properties.Resources.awwwwww;
            }
            if (d == 5|| n==4)
            {
                pictureBox2.Image = Properties.Resources.dumb;
            }
            if (i == 5 || n==4)
            {
                pictureBox2.Image = Properties.Resources.rob;
            }
        }
    }
}
