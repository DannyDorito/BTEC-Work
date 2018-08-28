using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricGenerator
{
    public partial class Form1 : Form
    {
        List<string> lyric = new List<string>(); //Creates list lyric
        int line = 0;
        public Form1()
        {
            InitializeComponent();
            LyricMethod(); //Calls LyricMethod
        }
        private void LyricMethod()
        {
            lyric.Add("Min'na saikō arigatō,");
            lyric.Add("K-k-k-kawaii, k-k-k-kawaii.");
            lyric.Add("Mom's not home tonight");
            lyric.Add("So we can roll around, have a pillow fight");
            lyric.Add("Like a major rager OMFG");
            lyric.Add("Let's all slumber party");
            lyric.Add("Like a fat kid on a pack of Smarties");
            lyric.Add("Someone chuck a cupcake at me");
            lyric.Add("It's time for spin the bottle");
            lyric.Add("Not gonna talk about it tomorrow");
            lyric.Add("Keep it just between you and me");
            lyric.Add("Let's play truth or dare now");
            lyric.Add("We can roll around in our underwear how");
            lyric.Add("Every silly kitty should be");
            lyric.Add("Come come Kitty Kitty");
            lyric.Add("You're so pretty pretty");
            lyric.Add("Don't go Kitty Kitty");
            lyric.Add("Stay with me");
            lyric.Add("Come come Kitty Kitty");
            lyric.Add("You're so silly silly");
            lyric.Add("Don't go Kitty Kitty");
            lyric.Add("Play with me");
            lyric.Add("K-k-k-kawaii");
            lyric.Add("Hello Kitty, hello Kitty");
            lyric.Add("Hello Kitty, you're so pretty");
            lyric.Add("Hello Kitty, you're so silly");
            lyric.Add("Wake up, got a secret");
            lyric.Add("Pinky swear that you're gonna keep it");
            lyric.Add("I've got something you need to see");
            lyric.Add("Let's be friends forever");
            lyric.Add("I wanna do everything with you together");
            lyric.Add("Come and play with Kitty and me");
            lyric.Add("Come come Kitty Kitty");
            lyric.Add("You're so silly silly");
            lyric.Add("Don't go Kitty Kitty");
            lyric.Add("Stay with me");
            lyric.Add("Come come Kitty Kitty");
            lyric.Add("You're so silly silly");
            lyric.Add("Don't go Kitty Kitty");
            lyric.Add("Play with me");
            lyric.Add("K-k-k-kawaii");
            lyric.Add("Hello Kitty, hello Kitty");
            lyric.Add("Hello Kitty, you're so pretty");
            lyric.Add("Hello Kitty, hello Kitty");
            lyric.Add("Hello Kitty, you're so silly");
            lyric.Add("Min'na saikō arigatō! K-k-k-kawaii!");
            lyric.Add("K-k-k-kawaii!");
            lyric.Add("Meow.");
            lyric.Add("Hello Kitty, hello Kitty");
            lyric.Add("You're so pretty pretty");
            lyric.Add("Hello Kitty, hello Kitty");
            lyric.Add("Stay with me");
            lyric.Add("Come come Kitty Kitty");
            lyric.Add("You're so silly silly");
            lyric.Add("Don't go Kitty Kitty");
            lyric.Add("Play with me");
            lyric.Add("Hello Kitty");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Next Lyric";
            rtbOutput.Text = lyric[line];

            line++;

            if (line == lyric.Count)
            {
                line = 0;
                btnStart.Text = "Start";
            }
        }
    }
}
