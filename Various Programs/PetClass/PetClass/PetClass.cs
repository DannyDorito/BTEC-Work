using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PethTheDogeClassbut
{
    public partial class PetClass : Form
    {
        List<Pet> petlist = new List<Pet>();
        Pet pet;
        int petIndex = -1;

        public PetClass()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pet = new Pet(rtbName.Text);
            petlist.Add(pet);

            petForm(pet);

            petIndex++;

            tmr_1.Enabled = true;
        }
        private void petForm(Pet pet)
        {
            rtbHealth.Text = pet.HEALTH.ToString();
            rtbHunger.Text = pet.HUNGER.ToString();
            rtbHygine.Text = pet.HYGINE.ToString();
            rtbAge.Text = pet.AGE.ToString();
            rtbName.Text = pet.NAME;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (petIndex != petlist.Count - 1)
            {
                petIndex++;

                petForm(petlist[petIndex]);
            }
            if (petIndex == petlist.Count - 1)
            {
                //Nothing
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (petIndex != 0)
            {
                petIndex--;

                petForm(petlist[petIndex]);
            }
            if (petIndex == 0)
            {
                //Nothing
            }
        }
        private void btnFeed_Click(object sender, EventArgs e)
        {
            pet.HUNGER += 15;
            
            if (pet.HUNGER >= 100)
            {
                pet.HUNGER = 100;
                petForm(petlist[petIndex]);
            }
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            pet.HYGINE += 15;
            if (pet.HYGINE >= 100)
            {
                pet.HYGINE = 100;
                petForm(petlist[petIndex]);
            }
        }
        private void tmr_1_Tick(object sender, EventArgs e)
        {
            List<int> deadlist = new List<int>();
            for (int i = 0; i < petlist.Count; i++)
            {
                petlist[i].HUNGER--;
                petlist[i].HYGINE--;

                if (pet.HUNGER < 0)
                {
                    pet.HUNGER = 0;
                    pet.HEALTH--;
                }
                if (pet.HUNGER <= 20)
                {
                    pet.HEALTH--;
                }
                if (pet.HYGINE < 0)
                {
                    pet.HYGINE = 0;
                    pet.HEALTH--;
                }
                if (pet.HYGINE <= 20)
                {
                    pet.HEALTH--;
                }
            }
            petForm(petlist[petIndex]);
        }
    }
}