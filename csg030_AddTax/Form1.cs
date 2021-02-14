using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace csg030_AddTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            //消費税計算用
            int money;

            //税込み金額
            double addTax;

            //消費税率8%
            const double tax = 0.08;

            money = int.Parse(textBoxMoney.Text);

            addTax = money;
            addTax *= (1 + tax);

            money = (int)addTax;

            labelAddTax.Text = money + " 円";
        }
    }
}
