using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compliment
{
    public partial class Compliment : Form
    {
        string name;
        string gender;
        int age;
        int randomnum;

        List<string> malelow = new List<string>();
        List<string> malemid = new List<string>();
        List<string> malehigh = new List<string>();

        List<string> femalelow = new List<string>();
        List<string> femalemid = new List<string>();
        List<string> femalehigh = new List<string>();

        Random rnd = new Random();

        public Compliment()
        {
            InitializeComponent();

            malelowMethod();
            malemidMethod();
            malehighMethod();

            femalelowMethod();
            femalemidMethod();
            femalehighMethod();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            name = rtbName.Text;
            gender = rtbGender.Text;
            age = int.Parse(rtbAge.Text);

            comparisonMethod();
        }
        private void comparisonMethod()
        {
            if (gender == "male" && age <= 20)
            {
                randomnum = rnd.Next(0, malelow.Count);
                rtbOutput.Text = name + " " + malelow[randomnum];
            }
            if (gender == "male" && age <= 40)
            {
                randomnum = rnd.Next(0, malemid.Count);
                rtbOutput.Text = name + " " + malemid[randomnum];
            }
            if (gender == "male" && age > 50)
            {
                randomnum = rnd.Next(0, malehigh.Count);
                rtbOutput.Text = name + " " + malehigh[randomnum];
            }
            if (gender == "female" && age <= 20)
            {
                randomnum = rnd.Next(0, femalelow.Count);
                rtbOutput.Text = name + " " + femalelow[randomnum];
            }
            if (gender == "female" && age <= 40)
            {
                randomnum = rnd.Next(0, femalemid.Count);
                rtbOutput.Text = name + " " + femalemid[randomnum];
            }
            if (gender == "female" && age > 50)
            {
                randomnum = rnd.Next(0, femalehigh.Count);
                rtbOutput.Text = name + " " + femalehigh[randomnum];
            }
        }
        private void malelowMethod()
        {
            malelow.Add("apple");
            malelow.Add("eyyboss");
        }
        private void malemidMethod()
        {
            malemid.Add("he");
            malemid.Add("hfee");
        }
        private void malehighMethod()
        {
            malehigh.Add("gjmdkd");
            malehigh.Add("gjmffefdkd");
        }
        private void femalelowMethod()
        {
            femalelow.Add("appgsjjztjzele");
            femalelow.Add("eyybby");
        }
        private void femalemidMethod()
        {
            femalemid.Add("dfw");
            femalemid.Add("deeffw");
        }
        private void femalehighMethod()
        {
            femalehigh.Add("gjmdhtzrrxhtrztxxrkd");
            femalehigh.Add("die");
        }
    }
}
