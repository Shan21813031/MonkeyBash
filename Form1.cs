using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Monkey
{
    /// <summary>
    /// Task 3.5 - 3.6 & IS 3.12
    /// This form makes 4 monkey images move around and show a message when
    /// the monkey image is clicked on as well as give points to hits and misses made.
    /// Author: Shan Ahmed 21813031
    /// </summary>
    public partial class Form1 : Form
    {
        private int x1,x2,x3,x4,y4,y3,y2,y1;
        private int hits, misses;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// The below block of changes the positioning of the monkey and provides a message when clicked on
        /// </summary>

        private void timer1_Tick(object sender, EventArgs e)
        {
            x1 = rand.Next(GamePanel.Width - 100);  // pick a random x1   
            y1 = rand.Next(GamePanel.Height - 100); // pick a random y1

            pbxPicture.Left = x1;              // set picture to these values
            pbxPicture.Top = y1;

            MessageBox.Left = x1 + 40;
            MessageBox.Top = y1;

            HitsLabel.Text = "Hits = " + hits + " Misses = " + misses;
            MessageBox.Text = " ";

            Refresh();                        // redraw in new position
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
            hits = 0;
            misses = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
        }

        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void GamePanel_Click(object sender, PaintEventArgs e)
        {
        }

        private void monkey4_Click(object sender, EventArgs e)
        {
            hits++;
            MessageBox.Text = "Ouch! You HIT Me!";
        }

        private void monkey3_Click(object sender, EventArgs e)
        {
            hits++;
            MessageBox.Text = "Ouch! You HIT Me!";
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            x4 = rand.Next(GamePanel.Width - 100);  // pick a random x4  
            y4 = rand.Next(GamePanel.Height - 100); // pick a random y4
            monkey4.Left = x4;              // set picture to these values
            monkey4.Top = y4;
        }

        private void GamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            misses++;
        }

        private void GamePanel_MouseHover(object sender, EventArgs e)
        {

        }

        private void monkey2_Click(object sender, EventArgs e)
        {
            hits++;
            MessageBox.Text = "Ouch! You HIT Me!";

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            x3 = rand.Next(GamePanel.Width - 100);  // pick a random x3  
            y3= rand.Next(GamePanel.Height - 100); // pick a random y3
            monkey3.Left = x3;              // set picture to these values
            monkey3.Top = y3;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Coordinates.Text = "(" + e.X + "," + e.Y + ")";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            x2 = rand.Next(GamePanel.Width - 100);  // pick a random x2   
            y2 = rand.Next(GamePanel.Height - 100); // pick a random y2
            monkey2.Left = x2;              // set picture to these values
            monkey2.Top = y2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxPicture_Click(object sender, EventArgs e)
        {
            hits++;
            MessageBox.Text = "Ouch! You HIT Me!";
            
            
        }


    }
}
