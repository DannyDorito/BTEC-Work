using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_
{
    public partial class Calculator : Form
    {
        List<string> symbol = new List<string>();
        Random rnd = new Random();

        int randomnumber;
        int num1;
        int num2;
        int numToGuess;
        int numAnswer;
        int count = 60;

        string countstr;
        string num1str;
        string num2str;
        public Calculator()
        {
            InitializeComponent();
            symbolMethod(); //Calls symbolMethod
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            count = 60;
            rtbInput.Enabled = true;
            btnSubmit.Enabled = true;
            btnStart.Enabled = false;
            tmr1.Enabled = true;
            randomMethod();

            if (num1 == num2 && num1 == 10)
            {
                randomMethod(); //Calls randomMethod
            }
        }
        private void randomMethod()
        {
            randomnumber = rnd.Next(0, symbol.Count); //Generates a random number
            lblSymbol.Text = symbol[randomnumber]; //Calls a random line from list

            num1 = rnd.Next(1, 11); //Generates a number between 1 and 10
            num2 = rnd.Next(1, 11); //Generates a number between 1 and 10

            if (lblSymbol.Text == "+")
            {
                numToGuess = num1 + num2;

                stringMethod(); //Calls the stringMethod
            }
            if (lblSymbol.Text == "-")
            {
                numToGuess = num1 - num2; //Calls the stringMethod

                stringMethod();
            }
            if (lblSymbol.Text == "x")
            {
                numToGuess = num1 * num2;

                stringMethod(); //Calls the stringMethod

                if (num1 < num2)
                {
                    num1 = rnd.Next(1, 11); //Regenerates a random number
                    num2 = rnd.Next(1, 11); //Regenerates a random number
                }
            }
            if (lblSymbol.Text == "÷")
            {
                numToGuess = num1 / num2;

                stringMethod(); //Calls the stringMethod

                if (num1 < num2)
                {
                    num1 = rnd.Next(1, 11); //Regenerates a random number
                    num2 = rnd.Next(1, 11); //Regenerates a random number
                }
            }
        }
        private void stringMethod()
        {
            num1str = num1.ToString();
            rtbNum1.Text = num1str;

            num2str = num2.ToString();
            rtbNum2.Text = num2str;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            numAnswer = int.Parse(rtbInput.Text);
            if (numToGuess == numAnswer)
            {
                rtbInput.Text = "";
                randomMethod();
            }
        }
        private void symbolMethod()
        {
            symbol.Add("+");
            symbol.Add("-");
            symbol.Add("x");
            symbol.Add("÷");
        }
        private void tmr1_Tick(object sender, EventArgs e)
        {
            count--;
            countstr = count.ToString();
            lblTimer.Text = countstr;
            if (count == 0)
            {
                rtbInput.Enabled = false;
                btnSubmit.Enabled = false;
                btnStart.Enabled = true;
                tmr1.Enabled = false;
            }
        }
    }
}