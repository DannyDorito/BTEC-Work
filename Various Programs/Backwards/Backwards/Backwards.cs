using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backwards
{
    public partial class Backwards : Form
    {
        string words;
        bool reverse = false;
        int count = 10;
        string countstr;

        public Backwards()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            count = 10;
            char[] arr = rtbOutput.Text.ToCharArray(); //Changes the text to an array
            Array.Reverse(arr); //Reverses the array
            words = new string(arr); //Saves the array to words

            rtbOutput.Text = words;
            tmr1.Enabled = true; //Enables the timer
        }
        private void tmr1_Tick(object sender, EventArgs e)
        {
            count = count - 1;
            countstr = count.ToString(); //int to string
            rtbTimer.Text = countstr; //Outputs the string

            if (count == 0)
            {
                count = 10; 
                reverse = true; //Enables the reverse boolean
            }
            if (reverse == true)
            {
                char[] arr = rtbOutput.Text.ToCharArray(); //Changes the text to an array
                Array.Reverse(arr); //Reverses the array
                words = new string(arr); //Saves the array to words

                rtbOutput.Text = words; //Outputs the vairable
                reverse = false; //Disbles the vairable
            }
        }
    }
}
