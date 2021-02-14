using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace csg071_SwimmingSchedule
{
    public partial class Form1 : Form
    {
        private Course c0;
        private Course c1;
        private Course c2;
        private Course c3;
        private Course c4;
        private Course c5;
        private Course c6;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownYear.Value = DateTime.Now.Year;
            numericUpDownMonth.Value = DateTime.Now.Month;

            c0 = new Course((string)listBoxCourse.Items[0], 1, 14, 1000);
            c1 = new Course((string)listBoxCourse.Items[1], 2, 10, 1000);
            c2 = new Course((string)listBoxCourse.Items[2], 3, 17, 800);
            c3 = new Course((string)listBoxCourse.Items[3], 4, 19, 800);
            c4 = new Course((string)listBoxCourse.Items[4], 5, 20, 1000);
            c5 = new Course((string)listBoxCourse.Items[5], 6, 20, 1200);
            c6 = new Course((string)listBoxCourse.Items[6], 0, 10, 1500);
        }

        

        private void buttonShow_Click(object sender, EventArgs e)
        {
            int n = listBoxCourse.SelectedIndex;
            int year = (int)numericUpDownYear.Value;
            int month = (int)numericUpDownMonth.Value;

            switch (n)
            {
                case 0:
                    labelClassDays.Text = "授業日    ： " + c0.GetClassDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + c0.StartTime + "時";
                    labelMonthlyFee.Text = "月謝代    ： " + c0.GetMonthlyFee(year, month) + "円";
                    break;
                case 1:
                    labelClassDays.Text = "授業日    ： " + c1.GetClassDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + c1.StartTime + "時";
                    labelMonthlyFee.Text = "月謝代    ： " + c1.GetMonthlyFee(year, month) + "円";
                    break;
                case 2:
                    labelClassDays.Text = "授業日    ： " + c2.GetClassDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + c2.StartTime + "時";
                    labelMonthlyFee.Text = "月謝代    ： " + c2.GetMonthlyFee(year, month) + "円";
                    break;
                case 3:
                    labelClassDays.Text = "授業日    ： " + c3.GetClassDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + c3.StartTime + "時";
                    labelMonthlyFee.Text = "月謝代    ： " + c3.GetMonthlyFee(year, month) + "円";
                    break;
                case 4:
                    labelClassDays.Text = "授業日    ： " + c4.GetClassDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + c4.StartTime + "時";
                    labelMonthlyFee.Text = "月謝代    ： " + c4.GetMonthlyFee(year, month) + "円";
                    break;
                case 5:
                    labelClassDays.Text = "授業日    ： " + c5.GetClassDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + c5.StartTime + "時";
                    labelMonthlyFee.Text = "月謝代    ： " + c5.GetMonthlyFee(year, month) + "円";
                    break;
                case 6:
                    labelClassDays.Text = "授業日    ： " + c6.GetClassDays(year, month);
                    labelStartTime.Text = "開始時間 ： " + c6.StartTime + "時";
                    labelMonthlyFee.Text = "月謝代    ： " + c6.GetMonthlyFee(year, month) + "円";
                    break;
            }
        }

        private void numericUpDownYear_ValueChanged(object sender, EventArgs e)
        {
            labelClassDays.Text = "授業日　: ";
            labelStartTime.Text = "開始時間 : ";
            labelMonthlyFee.Text = "月謝代　: ";
        }
    }
}
