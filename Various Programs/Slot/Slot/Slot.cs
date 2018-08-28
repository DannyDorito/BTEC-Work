using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotItIN
{
    public partial class Slot : Form
    {
        int credit = 0;
        int spin1;
        int spin2;
        int spin3;
        string creditstr;
        string spin1str;
        string spin2str;
        string spin3str;

        Random rnd = new Random(); //Initializes random

        public Slot()
        {
            InitializeComponent();
        }
        private void btnMoney_Click(object sender, EventArgs e)
        {
            credit++;
            creditstr = credit.ToString();
            rtbCredit.Text = creditstr;

            btnSpin.Enabled = true;
        }
        private void btnSpin_Click(object sender, EventArgs e)
        {
            credit--;
            btnSpin.Enabled = false;
            btnMoney.Enabled = false;

            spinMethod(); //Calls spinMethod

            creditstr = credit.ToString(); //Outputs string
            rtbCredit.Text = creditstr; 

            btnSpin.Enabled = true;

            if (credit <= 0)
            {
                btnSpin.Enabled = false;
                btnMoney.Enabled = true;
            }
        }
        private void spinMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                spin1 = rnd.Next(1, 10);

                spin1str = spin1.ToString();
                rtbOutput1.Text = spin1str;
            }
            for (int i = 0; i < 100; i++)
            {
                spin2 = rnd.Next(1, 10);

                spin2str = spin2.ToString();
                rtbOutput2.Text = spin2str;
            }
            for (int i = 0; i < 100; i++)
            {
                spin3 = rnd.Next(1, 10);

                spin3str = spin3.ToString();
                rtbOutput3.Text = spin3str;
            }
            if (spin1 == spin2 && spin3 == spin2)
            {
                credit = credit + 3;
            }
            if (spin1 == 7 && spin2 == 7 && spin3 == 7)
            {
                credit = credit + 25;
            }
            if (spin1 == 1 && spin2 == 2 && spin3 == 1)
            {
                credit = credit + 21;
            }
            if (spin1 == 5 && spin2 == 1 && spin3 == 1)
            {
                credit = credit + 4;
            }
        }
    }
}
