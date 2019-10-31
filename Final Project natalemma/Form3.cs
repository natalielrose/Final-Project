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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int right = 0;
        
        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == false & radioButton2.Checked ==false & radioButton3.Checked == false & radioButton4.Checked == false)
            {
                MessageBox.Show("Please Select an Answer");
                
            }
            
            if (radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                right++;
                button3.Visible = true;
            }
            else if (radioButton2.Checked == true)  
            {
                radioButton1.BackColor = Color.LightGreen;
                radioButton2.BackColor = Color.Salmon;
                button3.Visible = true;
            }
            else if (radioButton3.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                radioButton3.BackColor = Color.Salmon;
                button3.Visible = true;
            }
            else if (radioButton4.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                radioButton4.BackColor = Color.Salmon;
                button3.Visible = true;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.WHOOOOOP;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.BackColor = Color.White;
            radioButton2.BackColor = Color.White;
            label2.Text = "Is this ride in Disney World or Disneyland?";
            radioButton1.Text = "Disneyland";
            radioButton2.Text = "Disney World";
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            button4.Visible = true;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false )
            {
                MessageBox.Show("Please Select an Answer");
            }
           
            if (radioButton2.Checked == true)
            {
                button5.Visible = true;
                radioButton2.BackColor = Color.LightGreen;
                right++;
                button4.Visible = false;
            }
            else if (radioButton1.Checked == true)
            {
                button5.Visible = true;
                radioButton2.BackColor = Color.LightGreen;
                radioButton1.BackColor = Color.Salmon;
                button4.Visible = false;
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.marshmallow;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.BackColor = Color.White;
            radioButton2.BackColor = Color.White;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton3.BackColor = Color.White;
            radioButton4.BackColor = Color.White;
            label2.Text = "What is the name of the snow monster in Frozen?";
            radioButton1.Text = "Fluffy";
            radioButton2.Text = "Marshmallow";
            radioButton3.Text = "Snowball";
            radioButton4.Text = "Ice Cube";
            button5.Visible = false;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false)
            {
                MessageBox.Show("Please Select an Answer");
            }
           
            if (radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.LightGreen;
                right++;
                button6.Visible = false;
                button7.Visible = true;
            }
            else if (radioButton1.Checked == true)
            {
                radioButton2.BackColor = Color.LightGreen;
                radioButton1.BackColor = Color.Salmon;
                button6.Visible = false;
                button7.Visible = true;
            }
            else if (radioButton3.Checked == true)
            {
                radioButton2.BackColor = Color.LightGreen;
                radioButton3.BackColor = Color.Salmon;
                button6.Visible = false;
                button7.Visible = true;
            }
            else if (radioButton4.Checked == true)
            {
                radioButton2.BackColor = Color.LightGreen;
                radioButton4.BackColor = Color.Salmon;
                button6.Visible = false;
                button7.Visible = true;
            }

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.he_point;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.BackColor = Color.White;
            radioButton2.BackColor = Color.White;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton3.BackColor = Color.White;
            radioButton4.BackColor = Color.White;
            label2.Text = "What year did Disneyland open?";
            radioButton1.Text = "1940";
            radioButton2.Text = "1967";
            radioButton3.Text = "1955";
            radioButton4.Text = "1952";
            button7.Visible = false;
            button8.Visible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false)
            {
                MessageBox.Show("Please Select an Answer");
            }
            
            if (radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.LightGreen;
                button8.Visible = false;
                button9.Visible = true;
                right++;
            }
            else if (radioButton1.Checked == true)
            {
                radioButton3.BackColor = Color.LightGreen;
                button8.Visible = false;
                button9.Visible = true;
                radioButton1.BackColor = Color.Salmon;
            }
            else if (radioButton2.Checked == true)
            {
                radioButton3.BackColor = Color.LightGreen;
                button8.Visible = false;
                button9.Visible = true;
                radioButton2.BackColor = Color.Salmon;
            }
            else if (radioButton4.Checked == true)
            {
                radioButton3.BackColor = Color.LightGreen;
                button8.Visible = false;
                button9.Visible = true;
                radioButton4.BackColor = Color.Salmon;
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.disneyland_castle;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.BackColor = Color.White;
            radioButton2.BackColor = Color.White;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton3.BackColor = Color.White;
            radioButton4.BackColor = Color.White;
            label2.Text = "Which Princess Lives in this Castle?";
            radioButton1.Text = "Aurora";
            radioButton2.Text = "Cinderella";
            radioButton3.Text = "Anna";
            radioButton4.Text = "Belle";
            button9.Visible = false;
            button10.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false)
            {
                MessageBox.Show("Please Select an Answer");
            }
            
            if (radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button10.Visible = false;
                button11.Visible = true;
                right++;
            }
            else if (radioButton3.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button10.Visible = false;
                button11.Visible = true;
                radioButton3.BackColor = Color.Salmon;
            }
            else if (radioButton2.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button10.Visible = false;
                button11.Visible = true;
                radioButton2.BackColor = Color.Salmon;
            }
            else if (radioButton4.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button10.Visible = false;
                button11.Visible = true;
                radioButton4.BackColor = Color.Salmon;
            }
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.BackColor = Color.White;
            radioButton2.BackColor = Color.White;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton3.BackColor = Color.White;
            radioButton4.BackColor = Color.White;
            label2.Text = "Which of These Rides Have Been Running Since Opening Day?";
            radioButton1.Text = "Splash Mountain";
            radioButton2.Text = "Autopia";
            radioButton3.Text = "Indiana Jones";
            radioButton4.Text = "Smuggler's Run";
            button11.Visible = false;
            button12.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false)
            {
                MessageBox.Show("Please Select an Answer");
            }
            
            if (radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.LightGreen;
                button12.Visible = false;
                button13.Visible = true;
                right++;
            }
            else if (radioButton3.Checked == true)
            {
                radioButton2.BackColor = Color.LightGreen;
                button12.Visible = false;
                button13.Visible = true;
                radioButton3.BackColor = Color.Salmon;
            }
            else if (radioButton1.Checked == true)
            {
                radioButton2.BackColor = Color.LightGreen;
                button12.Visible = false;
                button13.Visible = true;
                radioButton1.BackColor = Color.Salmon;
            }
            else if (radioButton4.Checked == true)
            {
                radioButton2.BackColor = Color.LightGreen;
                button12.Visible = false;
                button13.Visible = true;
                radioButton4.BackColor = Color.Salmon;
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.skinny;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.BackColor = Color.White;
            radioButton2.BackColor = Color.White;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton3.BackColor = Color.White;
            radioButton4.BackColor = Color.White;
            label2.Text = "Who Was the First Character Walt Designed?";
            radioButton1.Text = "Mickey Mouse";
            radioButton2.Text = "Snow White";
            radioButton3.Text = "Pluto";
            radioButton4.Text = "Oswald";
            button13.Visible = false;
            button14.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false)
            {
                MessageBox.Show("Please Select an Answer");
            }
            
            if (radioButton4.Checked == true)
            {
                radioButton4.BackColor = Color.LightGreen;
                button14.Visible = false;
                button15.Visible = true;
                right++;
            }
            else if (radioButton3.Checked == true)
            {
                radioButton4.BackColor = Color.LightGreen;
                button14.Visible = false;
                button15.Visible = true;
                radioButton3.BackColor = Color.Salmon;
            }
            else if (radioButton1.Checked == true)
            {
                radioButton4.BackColor = Color.LightGreen;
                button14.Visible = false;
                button15.Visible = true;
                radioButton1.BackColor = Color.Salmon;
            }
            else if (radioButton2.Checked == true)
            {
                radioButton4.BackColor = Color.LightGreen;
                button14.Visible = false;
                button15.Visible = true;
                radioButton2.BackColor = Color.Salmon;
            }
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.balloon;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.BackColor = Color.White;
            radioButton2.BackColor = Color.White;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton3.BackColor = Color.White;
            radioButton4.BackColor = Color.White;
            label2.Text = "Where is Disneyworld Located?";
            radioButton1.Text = "Orlando";
            radioButton2.Text = "Anaheim";
            radioButton3.Text = "Tampa Bay";
            radioButton4.Text = "Miami";
            button15.Visible = false;
            button16.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false)
            {
                MessageBox.Show("Please Select an Answer");
            }
            
            if (radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button16.Visible = false;
                button17.Visible = true;
                right++;
            }
            else if (radioButton3.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button16.Visible = false;
                button17.Visible = true;
                radioButton3.BackColor = Color.Salmon;
            }
            else if (radioButton4.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button16.Visible = false;
                button17.Visible = true;
                radioButton4.BackColor = Color.Salmon;
            }
            else if (radioButton2.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button16.Visible = false;
                button17.Visible = true;
                radioButton2.BackColor = Color.Salmon;
            }
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.silly_worms;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.BackColor = Color.White;
            radioButton2.BackColor = Color.White;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton3.BackColor = Color.White;
            radioButton4.BackColor = Color.White;
            label2.Text = "What Are the Names of Ursula's Pet Eels?";
            radioButton1.Text = "Flotsam and Jetsam";
            radioButton2.Text = "Steve and Jeff";
            radioButton3.Text = "Squiggly and Wiggly";
            radioButton4.Text = "They don't have names, Ursula calls them 'My Babies'";
            button17.Visible = false;
            button18.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false)
            {
                MessageBox.Show("Please Select an Answer");
            }
            
            if (radioButton1.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button18.Visible = false;
                button19.Visible = true;
                right++;
            }
            else if (radioButton3.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button18.Visible = false;
                button19.Visible = true;
                radioButton3.BackColor = Color.Salmon;
            }
            else if (radioButton4.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button18.Visible = false;
                button19.Visible = true;
                radioButton4.BackColor = Color.Salmon;
            }
            else if (radioButton2.Checked == true)
            {
                radioButton1.BackColor = Color.LightGreen;
                button18.Visible = false;
                button19.Visible = true;
                radioButton2.BackColor = Color.Salmon;
            }
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.speece;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton1.BackColor = Color.White;
            radioButton2.BackColor = Color.White;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton3.BackColor = Color.White;
            radioButton4.BackColor = Color.White;
            label2.Text = "What is the Space Ship Called in Wall-E";
            radioButton1.Text = "The Galactic Explorer";
            radioButton2.Text = "Spatium Navis";
            radioButton3.Text = "The Axiom";
            radioButton4.Text = "Buy N' Large";
            button19.Visible = false;
            button20.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false)
            {
                MessageBox.Show("Please Select an Answer");
            }
            
            if (radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.LightGreen;
                button20.Visible = false;
                button21.Visible = true;
                right++;
            }
            else if (radioButton1.Checked == true)
            {
                radioButton3.BackColor = Color.LightGreen;
                button20.Visible = false;
                button21.Visible = true;
                radioButton1.BackColor = Color.Salmon;
            }
            else if (radioButton4.Checked == true)
            {
                radioButton3.BackColor = Color.LightGreen;
                button20.Visible = false;
                button21.Visible = true;
                radioButton4.BackColor = Color.Salmon;
            }
            else if (radioButton2.Checked == true)
            {
                radioButton3.BackColor = Color.LightGreen;
                button20.Visible = false;
                button21.Visible = true;
                radioButton2.BackColor = Color.Salmon;
            }
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            label2.Text = "Your score was " + right + " out of 10";
            if (right == 10)
            {
                button21.Visible = false;
                pictureBox2.Image = Properties.Resources.sprinkle_the_spark;
                label3.Visible = true;
                label3.Text = "You are the ultimate Disney fan! You obviously know your stuff! This was too easy for you. Congrats on getting a perfect score!";

            }
            else if (right >= 9)
            {
                button21.Visible = false;
                pictureBox2.Image = Properties.Resources.cute_boi;
                label3.Visible = true;
                label3.Text = "You obviously like Disney! You may not be an expert yet, but you are well on your way!";
            }
            else if (right >= 5)
            {
                button21.Visible = false;
                pictureBox2.Image = Properties.Resources.smile;
                label3.Visible = true;
                label3.Text = "You obviously like Disney! You may not be an expert yet, but you are well on your way!";
            }
            else if (right <= 3)
            {
                button21.Visible = false;
                pictureBox2.Image = Properties.Resources.cronch_cronch;
                label3.Visible = true;
                label3.Text = "Maybe you should do some research because your Disney skills could be better... Try a trip to Disneyland!";
            }


        }


    }
}
