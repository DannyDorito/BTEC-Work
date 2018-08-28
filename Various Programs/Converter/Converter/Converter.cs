using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Converter : Form
    {
        double euro = 0.72;
        double pound = 1;

        double currencyOutput;
        double currency;

        string selectedcurrency1;
        string selectedcurrency2;
        string currencyOutputstr;

        public Converter()
        {
            InitializeComponent();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            selectedcurrency1 = cmbCurrency1.SelectedText;
            selectedcurrency2 = cmbCurrency2.SelectedText;
            currency = Int32.Parse(rtbInput.Text);

            if (selectedcurrency1 == "Euro" && selectedcurrency2 == "Pound")
            {
                currencyOutput = currency * pound;

                currencyOutputstr = currencyOutput.ToString();
                rtbOutput.Text = currencyOutputstr;
            }
            if (selectedcurrency1 == "Pound" && selectedcurrency2 == "Euro")
            {
                currencyOutput = currency * euro;

                currencyOutputstr = currencyOutput.ToString();
                rtbOutput.Text = currencyOutputstr;
            }
        }
    }
}
