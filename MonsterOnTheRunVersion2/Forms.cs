using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterOnTheRunVersion2
{
    public partial class Forms : Form
    {

        Random rnd = new Random();
        int gravity = 8;
        int score = 0;
        int speed = 12;
        bool moveLeft;
        bool moveRight;


        public Forms()
        {
            InitializeComponent();
        }

        private void playtimer(object sender, EventArgs e)
        {
            player.Top += gravity; // drop the player from the top
            label1.Text = "Score: " + score; // show the score on the label

            if (moveLeft && player.Left > 1) 
            // if move left is true and player left is greater than 1
            {
                player.Left -= speed;
                //move player to the left
            }
            if(moveRight && player.Left + player.Width < panel1.Width)
            // if player right is true and player left plus player width is greater than panel1s width
            {
                player.Left += speed;
                //move player to the right
            }

            foreach (Control x in panel1.Controls)
            // this for loop has a control called x and will be used to search for components
            // in the panel 1
            {
                if (x is Panel && x.Tag == "platform")
                {

                     x.Top -= 5;
                    // move the x to the top by 5 pixels

                    if (x.Top < panel1.Top - x.Height)
                     // if x's top is less then panel 1 top minus x's height
                    {
                        x.Top = panel1.Height + x.Height;
                        //  re-position x top to bottom of panel 1

                        x.Width = rnd.Next(100, 400);
                        // give x a random width
                       
                        score++;
                        // increase score by one
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    // if player collides with x
                    {
                        gravity = 0;
                        // change gravity value to 0 
                        player.Top = x.Top - player.Height;
                        // stop the player from going through the picture box and position it on top
                    }
                    else 
                    {
                        gravity = 8;
                        // if not then change gravity to 8;
                    }
                }


                if (x is PictureBox && x.Tag == "platform")
                // if x is type of picturebox and has a tag strign platform
                {
                    x.Top -= 5;
                    // move the x to the top by 5 pixels

                    if (x.Top < panel1.Top - x.Height)
                     // if x's top is less then panel 1 top minus x's height
                    {
                        x.Top = panel1.Height + x.Height;
                        //  re-position x top to bottom of panel 1

                        x.Width = rnd.Next(100, 400);
                        // give x a random width
                       
                        score++;
                        // increase score by one
                    }

                    if (player.Bounds.IntersectsWith(x.Bounds))
                    // if player collides with x
                    {
                        gravity = 0;
                        // change gravity value to 0 
                        player.Top = x.Top - player.Height;
                        // stop the player from going through the picture box and position it on top
                    }
                    else 
                    {
                        gravity = 8;
                        // if not then change gravity to 8;
                    }


                }
            }

            if (player.Top + player.Height < 0 || player.Top > panel1.Height)
            // if player top reaches top of the panel OR 
            // player drops to the bottom of the panel
            {
                gameTimer.Stop();
                // stop the timer
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left) 
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right) 
            {
                moveRight = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }

        }

       
    }
}
