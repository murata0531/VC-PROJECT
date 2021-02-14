using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace csg061_MultiAlarm
{
    public partial class FormClock : Form
    {
        private int alarmHour1 = 0;     // アラーム時1
        private int alarmMinute1 = 0;   // アラーム分1
        private int alarmHour2 = 0;     // アラーム時2
        private int alarmMinute2 = 0;   // アラーム分2
        private int alarmHour3 = 0;     // アラーム時3
        private int alarmMinute3 = 0;   // アラーム分3
        public FormClock()
        {
            InitializeComponent();
        }

        private void FormClock_Load(object sender, EventArgs e)
        {
            // タイマーを起動し、現在時刻を表示
            timer1.Start();
            labelClock.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 現在時刻の表示
            labelClock.Text = DateTime.Now.ToLongTimeString();

            // アラーム1の処理
            if (checkBoxAlm1.Checked == true)
            {
                if (alarmHour1 == DateTime.Now.Hour &&
                    alarmMinute1 == DateTime.Now.Minute)
                {
                    checkBoxAlm1.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム1",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // アラーム2の処理
            if (checkBoxAlm2.Checked == true)
            {
                if (alarmHour2 == DateTime.Now.Hour &&
                    alarmMinute2 == DateTime.Now.Minute)
                {
                    checkBoxAlm2.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム2",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            // アラーム3の処理
            if (checkBoxAlm3.Checked == true)
            {
                if (alarmHour3 == DateTime.Now.Hour &&
                    alarmMinute3 == DateTime.Now.Minute)
                {
                    checkBoxAlm3.Checked = false;
                    MessageBox.Show("時間ですよ！", "アラーム3",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonSet1_Click(object sender, EventArgs e)
        {
            FormSettings formSet1 = new FormSettings();
            if (formSet1.ShowDialog() == DialogResult.OK)
            {
                alarmHour1 = formSet1.alarmHour;
                alarmMinute1 = formSet1.alarmMinute;
                checkBoxAlm1.Text = alarmHour1.ToString("00") + ":" + alarmMinute1.ToString("00");
                checkBoxAlm1.Checked = true;
            }
            formSet1.Dispose();
        }

        private void buttonSet2_Click(object sender, EventArgs e)
        {
            FormSettings formSet2 = new FormSettings();
            if (formSet2.ShowDialog() == DialogResult.OK)
            {
                alarmHour2 = formSet2.alarmHour;
                alarmMinute2 = formSet2.alarmMinute;
                checkBoxAlm2.Text = alarmHour2.ToString("00") + ":" + alarmMinute2.ToString("00");
                checkBoxAlm2.Checked = true;
            }
            formSet2.Dispose();
        }

        private void buttonSet3_Click(object sender, EventArgs e)
        {
            FormSettings formSet3 = new FormSettings();
            if (formSet3.ShowDialog() == DialogResult.OK)
            {
                alarmHour3 = formSet3.alarmHour;
                alarmMinute3 = formSet3.alarmMinute;
                checkBoxAlm3.Text = alarmHour3.ToString("00") + ":" + alarmMinute3.ToString("00");
                checkBoxAlm3.Checked = true;
            }
            formSet3.Dispose();
        }
    }
}
