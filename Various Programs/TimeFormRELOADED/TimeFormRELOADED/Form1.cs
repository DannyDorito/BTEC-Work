using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeFormRELOADED
{
    public partial class Form1 : Form
    {
        int speed = 5; //Defines the move speed of the image beforehand
        public Form1()
        {
            InitializeComponent();
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            tmrAnimate.Enabled = !(tmrAnimate.Enabled);
            if (tmrAnimate.Enabled)
            {
                btnMove.Text = "Stop";
            }
            else
            {
                btnMove.Text = "Start";
            }
        }
        private void tmrAnimate_Tick(object sender, EventArgs e)
        {
            int posX, posY;

            posX = picStan.Location.X;
            posY = picStan.Location.Y;

            posX += speed;

            picStan.Location = new Point(posX, posY); //Changes the location of stan.png

            if (posX > this.Size.Width - picStan.Size.Width) //Finds the width of the form - picture size
            {
                speed = -5;
            }
            if (posX < this.Size.Width - picStan.Size.Width) //Finds the width of the form - picture size
            {
                speed = 5;
            }
        }
    }
}
