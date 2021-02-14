using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace csg060_AlarmTimer
{
    
    public partial class FormClock : Form
    {
        private bool alarmSetFlag = false;  // アラームセット中フラグ
        private int alarmHour = 0;          // アラーム時
        private int alarmMinute = 0;        // アラーム分
        private int alarmSecond = 0;        // アラーム秒

        public FormClock()
        {
            InitializeComponent();
        }

        private void FormClock_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelStatus.Text = "";
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日(ddd)");
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToLongTimeString();
            labelDate.Text = DateTime.Today.ToString("yyyy年MM月dd日(ddd)");

            // アラーム設定中
            if (alarmSetFlag == true)
            {
                // 設定時間になった
                if (alarmHour == now.Hour &&
                    alarmMinute == now.Minute &&
                    alarmSecond == now.Second)
                {
                    alarmSetFlag = false;
                    MessageBox.Show("時間ですよ！", "アラーム",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelStatus.Text = "";
                }
            }
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            FormSettings form2 = new FormSettings();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // アラームの設定
                alarmSetFlag = true;
                alarmHour = form2.alarmHour;
                alarmMinute = form2.alarmMinute;
                alarmSecond = form2.alarmSecond;
                labelStatus.Text = "♪ " + alarmHour.ToString("00") + ":"
                                         + alarmMinute.ToString("00") + ":"
                                         + alarmSecond.ToString("00");
            }
            form2.Dispose();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            alarmSetFlag = false;
            labelStatus.Text = "";
        }
    }
}
