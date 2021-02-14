using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace csg041_WeekOfDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelW.Text = "";
        }

        //閏年判定関数//
        private bool IsLeapYr(int y)
        {
            if ((y % 4 == 0 && y % 100 != 0) || y % 400 == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        //年月日妥当性関数//
        private bool IsValidDate(int y, int m, int d)
        {
            bool rc = true;

            //月が1から12ではない場合、また、日が1より小さい場合、妥当性エラー
            if (m < 1 || m > 12 || d < 1)
                rc = false;
            //小の月以外の場合、日が32以上で妥当性エラー
            else if (m == 1 || m == 3 || m == 5 || m == 7 ||
                m == 8 || m == 10 || m == 12)
            {
                if (d > 31)
                    rc = false;
            }
            //2以外の小の月の場合、31日以上で妥当性エラー
            else if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                if (d > 30)
                    rc = false;
            }
            //2月の場合
            else
            {
                //閏年の場合、30日以上で妥当性エラー
                if (IsLeapYr(y) == true)
                {
                    if (d > 29)
                        rc = false;
                }
                //閏年ではない場合、29日以上で妥当性エラー
                else
                {
                    if (d > 28)
                        rc = false;
                }
            }

            return rc;
        }

        //曜日no取得関数//
        private int GetWeekOfDay(int y, int m, int d)
        {
            //1月と2月は前年の延長として計算（年-1、月+12）
            if (m == 1 || m == 2)
            {
                y--;
                m += 12;
            }
            //Zellerの公式により、曜日番号を取得
            return (5 * y / 4 - y / 100 + y / 400 + (26 * m + 16) / 10 + d) % 7;
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(textBoxY.Text, out year) != true || year < 0)
            {
                labelW.Text = "西暦年エラー";
                return;
            }

            int month = (int)numericUpDownM.Value;
            int day = (int)numericUpDownD.Value;

            if (IsValidDate(year, month, day) == false)
            {
                labelW.Text = "あり得ない日付";
                return;
            }
            int week = GetWeekOfDay(year, month, day);

            switch (week)
            {
                case 0:
                    labelW.Text = "日曜日です";
                    break;
                case 1:
                    labelW.Text = "月曜日です";
                    break;
                case 2:
                    labelW.Text = "火曜日です";
                    break;
                case 3:
                    labelW.Text = "水曜日です";
                    break;
                case 4:
                    labelW.Text = "木曜日です";
                    break;
                case 5:
                    labelW.Text = "金曜日です";
                    break;
                case 6:
                    labelW.Text = "土曜日です";
                    break;
                default:
                    labelW.Text = "算出エラーです";
                    break;
            }
        }
    }
}
