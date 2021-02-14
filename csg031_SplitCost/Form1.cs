using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace csg031_SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxTaxFreePrice.Text = "0";
            textBoxNum.Text = "0";
            labelEachPay.Text = "";
            labelShortage.Text = "";
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {

            const double taxpercentile = 8.0;

            int money = int.Parse(textBoxTaxFreePrice.Text);
            int n = int.Parse(textBoxNum.Text);

            double addtax;

            addtax = money;
            addtax *= 1.08;

            //税込金額
            money = (int)addtax;

            int labelresult = money / n;

            int re = money % n;


            labelEachPay.Text = labelresult.ToString() + "円";
            labelShortage.Text = re.ToString() + "円";

        }
    }
}
