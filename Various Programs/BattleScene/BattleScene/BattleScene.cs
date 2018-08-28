using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BattleScene
{
    public partial class CharacterSpecs : Form
    {
        public CharacterSpecs()
        {
            InitializeComponent();
        }
        private void CharacterSpecs_Load(object sender, EventArgs e)
        {
            bool counter = true; //Boolean to initialize once
            if (counter)
            {
                Random rnd = new Random(); //Initializes semi-random numbers

                int level = Int32.Parse(txtLevel.Text);

                int brawn = rnd.Next(1, 21); //Randomizes stats from 1 - 20
                int dexterity = rnd.Next(1, 21);
                int vitality = rnd.Next(1, 21);
                int wisdom = rnd.Next(1, 21);
                int mind = rnd.Next(1, 21);
                int will = rnd.Next(1, 21);
                int luck = rnd.Next(1, 21);

                level = skillMethod(level, brawn, dexterity, vitality, wisdom, mind, will, luck);
                txtBrawn.Text = brawn.ToString(); //Converts an int to string, then outputs to screen
                txtDexterity.Text = dexterity.ToString();
                txtVitality.Text = vitality.ToString();
                txtWisdom.Text = wisdom.ToString();
                txtMind.Text = mind.ToString();
                txtWill.Text = will.ToString();
                txtLuck.Text = luck.ToString();
                txtLevel.Text = level.ToString();
            }
        }
        private static int skillMethod(int level, int brawn, int dexterity, int vitality, int wisdom, int mind, int will, int luck)
        {
            if (brawn >= 17) //When a stat value is greater or equal to 17, add one to level
            {
                level = +1;
            }
            if (dexterity >= 17)
            {
                level = +1;
            }
            if (vitality >= 17)
            {
                level = +1;
            }
            if (wisdom >= 17)
            {
                level = +1;
            }
            if (mind >= 17)
            {
                level = +1;
            }
            if (will >= 17)
            {
                level = +1;
            }
            if (luck >= 17)
            {
                level = +1;
            }
            return level;
        }
    }
}
