using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace csg021_ControlCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //アップダウンの変更イベント
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           labelNumericUpDown.Text = numericUpDown1.Name + " : " + numericUpDown1.Value;
        }

        //ラジオボタンの変更イベント
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton1.Text = radioButton1.Name + " : " + radioButton1.Checked;
        }

        //チェックボックスの変更イベント
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelCheckBox.Text = checkBox1.Name + " : " + checkBox1.Checked;
        
         }

        //ラジオボタンの変更イベント
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelRadioButton2.Text = radioButton2.Name + " : " + radioButton2.Checked;
        }
    }
}
