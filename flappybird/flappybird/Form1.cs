using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybird
{
    public partial class Form1 : Form
    {
        int pipespeed = 8;
        int gravity =5;
        int scores = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timerevent(object sender, EventArgs e)
        {
            pipedown.Left -= pipespeed;
            pipeup.Left -= pipespeed;
            flappyBird.Top += gravity;
            score.Text = "Score : " + scores;

            if(flappyBird.Top<9)
            {
                flappyBird.Top = 5;
            }
            if (scores>5)
            {
                pipespeed =15;
            }

            if(pipeup.Left<-50)
            {
                pipeup.Left = 600;
                
            }
            if (pipedown.Left < -50)
            {
                pipedown.Left = 550;
                scores++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipedown.Bounds) ||
               flappyBird.Bounds.IntersectsWith(pipeup.Bounds) ||
               flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
               )
            {
                endgame();
            } 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void endgame()
        {
            timer1.Stop();
            score.Text = "Game Over!!!";
        }

        private void keydown(object sender, KeyEventArgs e)
        {
        if(e.KeyCode==Keys.Space)
         {
    gravity = -5;
         }
        }

        private void keyup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
    }
}
