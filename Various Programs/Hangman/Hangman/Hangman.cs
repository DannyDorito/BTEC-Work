using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {
        List<string> wordsList = new List<string>();
        List<string> wordsGuessed = new List<string>();

        Random rnd = new Random(); //Initalizes semi-random numbers

        int lives = 5;
        int randomnumber = 0;
        string wordToGuess = "";
        string guess = "";

        public Hangman()
        {
            InitializeComponent();
            wordsToGuessMethod();
        }
        private void wordsToGuessMethod()
        {
            wordsList.Add("apple");
            wordsList.Add("cow");
            wordsList.Add("cat");
            wordsList.Add("panda");
            wordsList.Add("pencil");
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            randomnumber = rnd.Next(1, wordsList.Count);
            wordsList[randomnumber] = wordToGuess;

            btnStart.Visible = false;
            rtbStart.Visible = false;
            btnInput.Enabled = true;
            rtbInput.Enabled = true;
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            guess = rtbInput.Text;
            string livesstr = lives.ToString();
            if (guess != wordToGuess)
            {
                lives--;
                livesstr = lives.ToString();
                rtbLives.Text = livesstr;
            }
            if (guess == wordToGuess)
            {
                rtbInput.Text = "Well Done!";
            }
            if (lives == -1)
            {
                lives = 5;
                livesstr = lives.ToString();
                rtbLives.Text = livesstr;

                btnInput.Enabled = false;
                btnStart.Visible = true;
                rtbStart.Visible = true;
                rtbInput.Enabled = false;
            }
        }
    }
}
