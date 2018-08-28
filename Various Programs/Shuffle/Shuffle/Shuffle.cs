using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruffleShuffle
{
    public partial class Shuffle : Form
    {
        List<string> wordsList = new List<string>();
        Random rnd = new Random(); //Initalizes semi-random numbers

        int count = 31;
        int randomnumber;
        string wordToScramble;
        int letter1;
        int letter2;
        int scramble = 10000;
        char[] wordArray;

        public Shuffle()
        {
            InitializeComponent();
            wordsMethod();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmr1.Enabled = true;
            btnStart.Enabled = false;
            btnInput.Enabled = true;

            string wordToScramble = wordsList[rnd.Next(0, wordsList.Count())];
            char[] wordArray = wordToScramble.ToCharArray();
            if (scramble != 0)
            {
                foreach (var letter in wordToScramble)
                {
                    letter1 = rnd.Next(0, wordToScramble.Length);
                    letter2 = rnd.Next(0, wordToScramble.Length);

                    char temp = wordArray[letter1];
                    wordArray[letter1] = wordArray[letter2];
                    wordArray[letter2] = temp;
                    
                    scramble--;
                }
            }
            string anagram = new string(wordArray);
            rtbOutput.Text = anagram;
            count = 31;
        }
        private void wordsMethod()
        {
            wordsList.Add("apple");
            wordsList.Add("cow");
            wordsList.Add("cat");
            wordsList.Add("panda");
            wordsList.Add("pencil");
        }
        private void tmr1_Tick(object sender, EventArgs e)
        {
            count = count - 1;
            string countstr = count.ToString();
            rtbTimer.Text = countstr;

            if (count == 0)
            {
                tmr1.Enabled = false;
                btnStart.Enabled = true;
                btnInput.Enabled = false;

                rtbInput.Text = "";
                rtbOutput.Text = "";

                count = 31;
            };
        }
    }
}
