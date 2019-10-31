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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
        }
        int cinderella = 0;
        int belle = 0;
        int ariel = 0;
        int mulan = 0;
        int vanellope = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false & radioButton5.Checked == false)
            {
                MessageBox.Show("Please select an answer");
            }
            if (radioButton1.Checked == true)
            {
                cinderella++;
                label2.Text = "Who is your sidekick?";
                radioButton1.Text = "A Mouse";
                radioButton2.Text = "A Horse";
                radioButton3.Text = "A Fish";
                radioButton4.Text = "A Cricket";
                radioButton5.Text = "A Racecar";
                radioButton1.Checked = false;

            }
            if (radioButton2.Checked == true)
            {
                belle++;
                label2.Text = "Who is your sidekick?";
                radioButton1.Text = "A Mouse";
                radioButton2.Text = "A Horse";
                radioButton3.Text = "A Fish";
                radioButton4.Text = "A Cricket";
                radioButton5.Text = "A Racecar";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                ariel++;
                label2.Text = "Who is your sidekick?";
                radioButton1.Text = "A Mouse";
                radioButton2.Text = "A Horse";
                radioButton3.Text = "A Fish";
                radioButton4.Text = "A Cricket";
                radioButton5.Text = "A Racecar";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                mulan++;
                label2.Text = "Who is your sidekick?";
                radioButton1.Text = "A Mouse";
                radioButton2.Text = "A Horse";
                radioButton3.Text = "A Fish";
                radioButton4.Text = "A Cricket";
                radioButton5.Text = "A Racecar";
                radioButton4.Checked = false;
            }
            if (radioButton5.Checked == true)
            {
                vanellope++;
                label2.Text = "Who is your sidekick?";
                radioButton1.Text = "A Mouse";
                radioButton2.Text = "A Horse";
                radioButton3.Text = "A Fish";
                radioButton4.Text = "A Cricket";
                radioButton5.Text = "A Racecar";
                radioButton5.Checked = false;
            }
            button2.Visible = false;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false & radioButton5.Checked == false)
            {
                MessageBox.Show("Please select an answer");
            }
            if (radioButton1.Checked == true)
            {
                cinderella++;
                label2.Text = "What is your favorite hobby?";
                radioButton1.Text = "Cleaning";
                radioButton2.Text = "Reading";
                radioButton3.Text = "Swimming";
                radioButton4.Text = "Working Out";
                radioButton5.Text = "Racing";
                radioButton1.Checked = false;

            }
            if (radioButton2.Checked == true)
            {
                belle++;
                label2.Text = "What is your favorite hobby?";
                radioButton1.Text = "Cleaning";
                radioButton2.Text = "Reading";
                radioButton3.Text = "Swimming";
                radioButton4.Text = "Working Out";
                radioButton5.Text = "Racing";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                ariel++;
                label2.Text = "What is your favorite hobby?";
                radioButton1.Text = "Cleaning";
                radioButton2.Text = "Reading";
                radioButton3.Text = "Swimming";
                radioButton4.Text = "Working Out";
                radioButton5.Text = "Racing";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                mulan++;
                label2.Text = "What is your favorite hobby?";
                radioButton1.Text = "Cleaning";
                radioButton2.Text = "Reading";
                radioButton3.Text = "Swimming";
                radioButton4.Text = "Working Out";
                radioButton5.Text = "Racing";
                radioButton4.Checked = false;
            }
            if (radioButton5.Checked == true)
            {
                vanellope++;
                label2.Text = "What is your favorite hobby?";
                radioButton1.Text = "Cleaning";
                radioButton2.Text = "Reading";
                radioButton3.Text = "Swimming";
                radioButton4.Text = "Working Out";
                radioButton5.Text = "Racing";
                radioButton5.Checked = false;
            }
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false & radioButton5.Checked == false)
            {
                MessageBox.Show("Please select an answer");
            }
            if (radioButton1.Checked == true)
            {
                cinderella++;
                label2.Text = "What is your favorite genre of music?";
                radioButton1.Text = "Classical";
                radioButton2.Text = "Musical Theatre";
                radioButton3.Text = "Reggae";
                radioButton4.Text = "Hip Hop";
                radioButton5.Text = "Pop";
                radioButton1.Checked = false;

            }
            if (radioButton2.Checked == true)
            {
                belle++;
                label2.Text = "What is your favorite genre of music?";
                radioButton1.Text = "Classical";
                radioButton2.Text = "Musical Theatre";
                radioButton3.Text = "Reggae";
                radioButton4.Text = "Hip Hop";
                radioButton5.Text = "Pop";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                ariel++;
                label2.Text = "What is your favorite genre of music?";
                radioButton1.Text = "Classical";
                radioButton2.Text = "Musical Theatre";
                radioButton3.Text = "Reggae";
                radioButton4.Text = "Hip Hop";
                radioButton5.Text = "Pop";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                mulan++;
                label2.Text = "What is your favorite genre of music?";
                radioButton1.Text = "Classical";
                radioButton2.Text = "Musical Theatre";
                radioButton3.Text = "Reggae";
                radioButton4.Text = "Hip Hop";
                radioButton5.Text = "Pop";
                radioButton4.Checked = false;
            }
            if (radioButton5.Checked == true)
            {
                vanellope++;
                label2.Text = "What is your favorite genre of music?";
                radioButton1.Text = "Classical";
                radioButton2.Text = "Musical Theatre";
                radioButton3.Text = "Reggae";
                radioButton4.Text = "Hip Hop";
                radioButton5.Text = "Pop";
                radioButton5.Checked = false;
            }
            button4.Visible = false;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false & radioButton5.Checked == false)
            {
                MessageBox.Show("Please select an answer");
            }
            if (radioButton1.Checked == true)
            {
                cinderella++;
                label2.Text = "What is your favorite holiday?";
                radioButton1.Text = "Valentine's Day";
                radioButton2.Text = "Christmas";
                radioButton3.Text = "Fourth of July";
                radioButton4.Text = "Halloween";
                radioButton5.Text = "New Year's";
                radioButton1.Checked = false;

            }
            if (radioButton2.Checked == true)
            {
                belle++;
                label2.Text = "What is your favorite holiday?";
                radioButton1.Text = "Valentine's Day";
                radioButton2.Text = "Christmas";
                radioButton3.Text = "Fourth of July";
                radioButton4.Text = "Halloween";
                radioButton5.Text = "New Year's";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                ariel++;
                label2.Text = "What is your favorite holiday?";
                radioButton1.Text = "Valentine's Day";
                radioButton2.Text = "Christmas";
                radioButton3.Text = "Fourth of July";
                radioButton4.Text = "Halloween";
                radioButton5.Text = "New Year's";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                mulan++;
                label2.Text = "What is your favorite holiday?";
                radioButton1.Text = "Valentine's Day";
                radioButton2.Text = "Christmas";
                radioButton3.Text = "Fourth of July";
                radioButton4.Text = "Halloween";
                radioButton5.Text = "New Year's";
                radioButton4.Checked = false;
            }
            if (radioButton5.Checked == true)
            {
                vanellope++;
                label2.Text = "What is your favorite holiday?";
                radioButton1.Text = "Valentine's Day";
                radioButton2.Text = "Christmas";
                radioButton3.Text = "Fourth of July";
                radioButton4.Text = "Halloween";
                radioButton5.Text = "New Year's";
                radioButton5.Checked = false;
            }
            button5.Visible = false;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false & radioButton5.Checked == false)
            {
                MessageBox.Show("Please select an answer");
            }
            if (radioButton1.Checked == true)
            {
                cinderella++;
                label2.Text = "What is your Starbucks order?";
                radioButton1.Text = "Pumpkin Spice Latte";
                radioButton2.Text = "Peppermint Mocha";
                radioButton3.Text = "Strawberry Acai Refresher";
                radioButton4.Text = "Iced Black Tea Lemonade";
                radioButton5.Text = "Hot Chocolate";
                radioButton1.Checked = false;

            }
            if (radioButton2.Checked == true)
            {
                belle++;
                label2.Text = "What is your Starbucks order?";
                radioButton1.Text = "Pumpkin Spice Latte";
                radioButton2.Text = "Peppermint Mocha";
                radioButton3.Text = "Strawberry Acai Refresher";
                radioButton4.Text = "Iced Black Tea Lemonade";
                radioButton5.Text = "Hot Chocolate";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                ariel++;
                label2.Text = "What is your Starbucks order?";
                radioButton1.Text = "Pumpkin Spice Latte";
                radioButton2.Text = "Peppermint Mocha";
                radioButton3.Text = "Strawberry Acai Refresher";
                radioButton4.Text = "Iced Black Tea Lemonade";
                radioButton5.Text = "Hot Chocolate";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                mulan++;
                label2.Text = "What is your Starbucks order?";
                radioButton1.Text = "Pumpkin Spice Latte";
                radioButton2.Text = "Peppermint Mocha";
                radioButton3.Text = "Strawberry Acai Refresher";
                radioButton4.Text = "Iced Black Tea Lemonade";
                radioButton5.Text = "Hot Chocolate";
                radioButton4.Checked = false;
            }
            if (radioButton5.Checked == true)
            {
                vanellope++;
                label2.Text = "What is your Starbucks order?";
                radioButton1.Text = "Pumpkin Spice Latte";
                radioButton2.Text = "Peppermint Mocha";
                radioButton3.Text = "Strawberry Acai Refresher";
                radioButton4.Text = "Iced Black Tea Lemonade";
                radioButton5.Text = "Hot Chocolate";
                radioButton5.Checked = false;
            }
            button6.Visible = false;
            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false & radioButton5.Checked == false)
            {
                MessageBox.Show("Please select an answer");
            }
            if (radioButton1.Checked == true)
            {
                cinderella++;
                label2.Text = "How would your friends describe you?";
                radioButton1.Text = "Organized";
                radioButton2.Text = "Smart";
                radioButton3.Text = "Inventive";
                radioButton4.Text = "Active";
                radioButton5.Text = "Impulsive";
                radioButton1.Checked = false;

            }
            if (radioButton2.Checked == true)
            {
                belle++;
                label2.Text = "How would your friends describe you?";
                radioButton1.Text = "Organized";
                radioButton2.Text = "Smart";
                radioButton3.Text = "Inventive";
                radioButton4.Text = "Active";
                radioButton5.Text = "Impulsive";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                ariel++;
                label2.Text = "How would your friends describe you?";
                radioButton1.Text = "Organized";
                radioButton2.Text = "Smart";
                radioButton3.Text = "Inventive";
                radioButton4.Text = "Active";
                radioButton5.Text = "Impulsive";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                mulan++;
                label2.Text = "How would your friends describe you?";
                radioButton1.Text = "Organized";
                radioButton2.Text = "Smart";
                radioButton3.Text = "Inventive";
                radioButton4.Text = "Active";
                radioButton5.Text = "Impulsive";
                radioButton4.Checked = false;
            }
            if (radioButton5.Checked == true)
            {
                vanellope++;
                label2.Text = "How would your friends describe you?";
                radioButton1.Text = "Organized";
                radioButton2.Text = "Smart";
                radioButton3.Text = "Inventive";
                radioButton4.Text = "Active";
                radioButton5.Text = "Impulsive";
                radioButton5.Checked = false;
            }
            button7.Visible = false;
            button8.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false & radioButton3.Checked == false & radioButton4.Checked == false & radioButton5.Checked == false)
            {
                MessageBox.Show("Please select an answer");
            }
            if (radioButton1.Checked == true)
            {
                cinderella++;
                label2.Text = "What's your favorite subject?";
                radioButton1.Text = "Home Ec";
                radioButton2.Text = "English";
                radioButton3.Text = "Art";
                radioButton4.Text = "PE";
                radioButton5.Text = "History";
                radioButton1.Checked = false;

            }
            if (radioButton2.Checked == true)
            {
                belle++;
                label2.Text = "What's your favorite subject?";
                radioButton1.Text = "Home Ec";
                radioButton2.Text = "English";
                radioButton3.Text = "Art";
                radioButton4.Text = "PE";
                radioButton5.Text = "History";
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked == true)
            {
                ariel++;
                label2.Text = "What's your favorite subject?";
                radioButton1.Text = "Home Ec";
                radioButton2.Text = "English";
                radioButton3.Text = "Art";
                radioButton4.Text = "PE";
                radioButton5.Text = "History";
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked == true)
            {
                mulan++;
                label2.Text = "What's your favorite subject?";
                radioButton1.Text = "Home Ec";
                radioButton2.Text = "English";
                radioButton3.Text = "Art";
                radioButton4.Text = "PE";
                radioButton5.Text = "History";
                radioButton4.Checked = false;
            }
            if (radioButton5.Checked == true)
            {
                vanellope++;
                label2.Text = "What's your favorite subject?";
                radioButton1.Text = "Home Ec";
                radioButton2.Text = "English";
                radioButton3.Text = "Art";
                radioButton4.Text = "PE";
                radioButton5.Text = "History";
                radioButton5.Checked = false;
            }
            button8.Visible = false;
            if (cinderella == ariel || cinderella == belle || cinderella == mulan || cinderella == vanellope || ariel == cinderella || ariel == belle || ariel == mulan || ariel == vanellope || belle == ariel || belle == cinderella || belle == mulan || belle == vanellope || mulan == ariel || mulan == cinderella || mulan == belle || mulan == vanellope || vanellope == cinderella || vanellope == ariel || vanellope == belle || vanellope == mulan)
            {
                button11.Visible = true;
            }
            else
            {
                button9.Visible = true;
            }
            
        }
        // question for if two are equal
        private void button11_Click(object sender, EventArgs e)
        {
            // cinderella with everyone else
            if (cinderella == ariel || ariel == cinderella)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Going to the beach.";
                radioButton2.Text = "Going to a dance.";
                radioButton3.Text = "Watching the sunset";
                radioButton4.Text = "Going shopping";
                radioButton5.Text = "Karaoke";
                if (radioButton1.Checked == true || radioButton3.Checked ==true || radioButton5.Checked == true)
                {
                    ariel++;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    cinderella++;
                    button9.Visible = true;
                }
            }
            if (cinderella == belle || belle == cinderella)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Coffee shop date.";
                radioButton2.Text = "Going to a dance.";
                radioButton3.Text = "Going to the snow";
                radioButton4.Text = "Going shopping";
                radioButton5.Text = "Horseback riding.";
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    belle++;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    cinderella++;
                    button9.Visible = true;
                }
            }
            if (cinderella == ariel || ariel == cinderella)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Going to the beach.";
                radioButton2.Text = "Going to a dance.";
                radioButton3.Text = "Watching the sunset";
                radioButton4.Text = "Going shopping";
                radioButton5.Text = "Karaoke";
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    ariel++;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    cinderella++;
                    button9.Visible = true;
                }
            }
            if (cinderella == mulan || mulan == cinderella)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Going on a hike.";
                radioButton2.Text = "Going to a dance.";
                radioButton3.Text = "Camping.";
                radioButton4.Text = "Going shopping";
                radioButton5.Text = "Archery.";
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    mulan++;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    cinderella++;
                    button9.Visible = true;
                }
            }
            if (cinderella == vanellope || vanellope == cinderella)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Go Kart Racing.";
                radioButton2.Text = "Going to a dance.";
                radioButton3.Text = "Going to a cooking class.";
                radioButton4.Text = "Going shopping";
                radioButton5.Text = "Going to Disneyland";
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    vanellope++;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    cinderella++;
                    button9.Visible = true;
                }
            }
            //belle with everyone else
            if (belle == ariel || ariel == belle)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Going to the beach.";
                radioButton2.Text = "Coffee date.";
                radioButton3.Text = "Watching the sunset";
                radioButton4.Text = "Horseback riding.";
                radioButton5.Text = "Karaoke";
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    ariel++;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    belle++;
                    button9.Visible = true;
                }
            }
            if (belle == mulan || mulan == belle)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Going on a hike.";
                radioButton2.Text = "Coffee date.";
                radioButton3.Text = "Camping.";
                radioButton4.Text = "Horseback Riding.";
                radioButton5.Text = "Archery.";
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    mulan++ ;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    belle++;
                    button9.Visible = true;
                }
            }
            if (belle == vanellope || vanellope == belle)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Go Kart Racing.";
                radioButton2.Text = "Coffee date.";
                radioButton3.Text = "Going to a cooking class.";
                radioButton4.Text = "Horseback Riding.";
                radioButton5.Text = "Going to Disneyland.";
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    vanellope++;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    belle++;
                    button9.Visible = true;
                }
            }
            //ariel w everyone 


            if (ariel == mulan || mulan == ariel)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Going to the beach.";
                radioButton2.Text = "Going on a hike.";
                radioButton3.Text = "Watching the sunset.";
                radioButton4.Text = "Going camping.";
                radioButton5.Text = "Karaoke.";
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    ariel++;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    mulan++;
                    button9.Visible = true;
                }
            }
            if (ariel == vanellope || vanellope == ariel)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Going to the beach.";
                radioButton2.Text = "Go Kart Racing.";
                radioButton3.Text = "Watching the sunset.";
                radioButton4.Text = "Going to a cooking class.";
                radioButton5.Text = "Karaoke.";
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    ariel++;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    vanellope++;
                    button9.Visible = true;
                }
            }

            //Mulan vibes
            if (mulan == vanellope || vanellope == mulan)
            {
                label2.Text = "Describe your dream date.";
                radioButton1.Text = "Go Kart racing.";
                radioButton2.Text = "Going on a hike.";
                radioButton3.Text = "Going to cooking classes.";
                radioButton4.Text = "Going camping.";
                radioButton5.Text = "Going to Disneyland.";
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true)
                {
                    vanellope++;
                    button9.Visible = true;
                }
                if (radioButton2.Checked == true || radioButton4.Checked == true)
                {
                    mulan++;
                    button9.Visible = true;
                }
            }
        }
        
        
        
        
        
        // button for results

        private void button9_Click(object sender, EventArgs e)
        {
            button10.Visible = true;
            pictureBox1.Visible = true;
            if (cinderella > ariel & cinderella > belle & cinderella > mulan & cinderella > vanellope)
            {
                pictureBox1.Image = Properties.Resources.cinder_hella_cool ;
                label3.Visible = true;
                label1.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                button9.Visible = false;
                
            }
            if (belle > ariel & belle > cinderella & belle > mulan & belle > vanellope)
            {
                pictureBox1.Image= Properties.Resources.skrt_skrt_skrt;
                label4.Visible = true;
                label1.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                button9.Visible = false;
            }
            if (ariel > belle & ariel > cinderella & ariel > mulan & ariel > vanellope)
            {
                pictureBox1.Image = Properties.Resources.swimmin;
                label5.Visible = true;
                label1.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                button9.Visible = false;
            }
            if (mulan > ariel & mulan > cinderella & mulan > belle & mulan > vanellope)
            {
                pictureBox1.Image = Properties.Resources.footisbroke;
                label6.Visible = true;
                label1.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                button9.Visible = false;
            }
            if (vanellope > ariel & vanellope > cinderella & vanellope > mulan & vanellope > belle)
            {
                pictureBox1.Image = Properties.Resources.giggle;
                label3.Visible = true;
                label7.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                button9.Visible = false;
            }
        }




        // reset button
        private void button10_Click(object sender, EventArgs e)
        {
            cinderella = 0;
            belle = 0;
            ariel = 0;
            mulan = 0;
            vanellope = 0;
            pictureBox1.Visible = false;
            label7.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            label1.Visible = true;
            button2.Visible = true;
            button10.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label2.Text = "Who is your sidekick?";
            radioButton1.Text = "A Mouse";
            radioButton2.Text = "A Horse";
            radioButton3.Text = "A Fish";
            radioButton4.Text = "A Cricket";
            radioButton5.Text = "A Racecar";


        }


    }
}
