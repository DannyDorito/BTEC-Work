using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        int human_number = 0;
        int computer_number = 0;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "Click a button to guess a number, between 1 and 10";
            computer_number = rnd.Next(1, 10); //Finds a random number, between 1 and 10

            EnableAll(); //Calles the Enable method

            btnStart.Enabled = false;
            btnStart.Visible = false;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            human_number = 1; //Changes the vairable 
            guess(); //Calls the guess method
            btn1.Enabled = false;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            human_number = 2; //Changes the vairable 
            guess(); //Calls the guess method
            btn2.Enabled = false;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            human_number = 3; //Changes the vairable 
            guess(); //Calls the guess method
            btn3.Enabled = false;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            human_number = 4; //Changes the vairable 
            guess(); //Calls the guess method
            btn4.Enabled = false;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            human_number = 5; //Changes the vairable 
            guess(); //Calls the guess method
            btn5.Enabled = false;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            human_number = 6; //Changes the vairable 
            guess(); //Calls the guess method
            btn6.Enabled = false;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            human_number = 7; //Changes the vairable 
            guess(); //Calls the guess method
            btn7.Enabled = false;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            human_number = 8; //Changes the vairable 
            guess(); //Calls the guess method
            btn8.Enabled = false;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            human_number = 9; //Changes the vairable 
            guess(); //Calls the guess method
            btn9.Enabled = false;
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            human_number = 10; //Changes the vairable 
            guess(); //Calls the guess method
            btn10.Enabled = false;
        }
        private void guess() //Creates a method, when a button is clicked
        {
            if (human_number == computer_number)
            {
                DisableAll(); //Calls the Disable method
                rtbOutput.Text = "Congratulations, you have won!";

                btnStart.Text = "Start";

                btnStart.Enabled = true;
                btnStart.Visible = true; //Makes the start button visible
            }
            if (human_number > computer_number)
            {
                rtbOutput.Text = "That number was too high, guess again";
            }
            if (human_number < computer_number)
                rtbOutput.Text = "That number was too low, guess again";
        }
        private void EnableAll() //Enables all choice buttons
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
        }
        private void DisableAll() //Disables all choice buttons
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn10.Enabled = false;
        }
    }
}
