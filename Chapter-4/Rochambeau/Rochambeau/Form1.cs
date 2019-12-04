using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rochambeau
{
    public partial class Form1 : Form
    {
        int randomRPS;
        int wins = 0;
        int losses = 0;
        public Form1()
        {
            
            InitializeComponent();
           
        }

        public void PassTheRPS()
        {
            Random rnd = new Random();
            randomRPS = rnd.Next(1, 4);
            //1 is rock 2 is paper 3 is scissors
        }
        public void WinsAndLosses()
        {
            lblWins.Text = "Wins : " + wins;
            lblLosses.Text = "Losses : " + losses;
        }
        public void WinCheck()
        {
            wins++;
        }
        public void LossCheck()
        {
            losses++;
        }
        private void lblScissors_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PassTheRPS();
            if (randomRPS == 1)
            {
                lblResult.Text = "Nothing happens! It was rock! Rock matches rock!";
            }
            else if (randomRPS == 2)
            {
                lblResult.Text = "You lose! It was paper! Paper beats rock!";
                LossCheck();
            }
            else if (randomRPS == 3)
            {
                lblResult.Text = "You win! It was scissors! Rock beats scissors!";
                WinCheck();
            }
            WinsAndLosses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassTheRPS();
            if (randomRPS == 1)
            {
                lblResult.Text = "You win! It was rock! Paper beats rock!";
                WinCheck();
            }
            else if (randomRPS == 2)
            {
                lblResult.Text = "Nothing happens! It was paper! Paper matches paper!";
            }
            else if (randomRPS == 3)
            {
                lblResult.Text = "You lose! It was scissors! Scissors beats paper";
                LossCheck();
            }
            WinsAndLosses();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PassTheRPS();
            if (randomRPS == 1)
            {
                lblResult.Text = "You lose! It was rock! Rock beats scissors!";
                LossCheck();
            }
            else if (randomRPS == 2)
            {
                lblResult.Text = "You win! It was paper! Scissors beats paper!";
                WinCheck();
            }
            else if (randomRPS == 3)
            {
                lblResult.Text = "Nothing happens! It was scissors! Scissors matches scissors!";
            }
            WinsAndLosses();
        }
    }
}
