using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Pet : Form
    {
        int food = 50;
        int water = 50;
        int weight = 50;
        int play = 50;
        int age = 4;

        string foodstr;
        string waterstr;
        string weightstr;
        string playstr;
        string agestr;

        public Pet()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            food = 50;
            water = 50;
            weight = 50;
            play = 50;
            age = 5;

            btnStart.Enabled = false;
            btnFood.Enabled = true;
            btnWater.Enabled = true;
            btnPlay.Enabled = true;

            tmr1.Enabled = true;

            Instructions F2 = new Instructions();
            F2.Show();
        }
        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (food == 70 && water == 70)
            {
                age++;
            }
            if (play == 70)
            {
                age++;
            }
            food = food - 5;
            water = water - 5;
            play = play - 10;

            outputMethod();

            if (food < 100) //Greater than 100 food
            {
                btnFood.Enabled = true;
            }
            if (water < 100) //Greater than 100 water
            {
                btnWater.Enabled = true;
            }
            if (play < 100) //Greater than 100 play
            {
                btnPlay.Enabled = true;
            }
            if (food < 0) //Less than 0 food
            {
                age--;
            }
            if (water < 0) //Less than 0 water
            {
                age--;
            }
            if (play < 0) //Less than 0 play
            {
                age--;
            }
            if (weight > 100) //Greater than 100 weight
            {
                age--;
            }
            if (age < 0)
            {
                tmr1.Enabled = false;

                btnStart.Enabled = true;
                btnFood.Enabled = false;
                btnWater.Enabled = false;
                btnPlay.Enabled = false;
            }
        }
        private void outputMethod()
        {
            foodstr = food.ToString();
            rtbFood.Text = foodstr;

            waterstr = water.ToString();
            rtbWater.Text = waterstr;

            playstr = play.ToString();
            rtbPlay.Text = playstr;

            agestr = age.ToString();
            rtbAge.Text = agestr;

            weightstr = weight.ToString();
            rtbWeight.Text = weightstr;
        }
        private void btnFood_Click(object sender, EventArgs e)
        {
            food = food + 15;
            weight = weight + 5;
            
            if (food >= 100)
            {
                btnFood.Enabled = false;
                food = 100;
            }
            outputMethod();
        }
        private void btnWater_Click(object sender, EventArgs e)
        {
            water = water + 15;
            play = play - 5;
            if (water >= 100)
            {
                btnWater.Enabled = false;
                water = 100;
            }
            outputMethod();
        }
        private void btnExercise_Click(object sender, EventArgs e)
        {
            play = play + 30;
            weight = weight - 15;
            if (play >= 100)
            {
                btnPlay.Enabled = false;
                play = 100;
            }
            outputMethod();
        }
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            Instructions Help = new Instructions();
            Help.ShowDialog();
        }
    }
}
