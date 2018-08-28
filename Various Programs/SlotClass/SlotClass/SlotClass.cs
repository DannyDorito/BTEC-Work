using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotiTInClassButtF
{
    public partial class SlotClass : Form
    {
        Machine slotmachine = new Machine();

        public SlotClass()
        {
            InitializeComponent();
        }
        private void ToForm(Machine slotmachine)
        {
            rtbCoin.Text = slotmachine.Balance.ToString();
        }

        private void btnCoin_Click(object sender, EventArgs e)
        {
            this.slotmachine.moneyin();
            rtbCoin.Text = slotmachine.Balance.ToString();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            rtbReel1 = this.slotmachine.start(ToString());
            rtbReel2 = this.slotmachine.start(ToString());
            rtbReel3 = this.slotmachine.start(ToString());
        }
    }
}
