﻿using System;
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
    public partial class FormSettings : Form
    {
        internal int alarmHour = 0;       // アラーム時
        internal int alarmMinute = 0;     // アラーム分
        internal int alarmSecond = 0;     // アラーム秒

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            // 現在時刻の表示
            numericUpDownAlmHour.Value = DateTime.Now.Hour;
            numericUpDownAlmMnt.Value = DateTime.Now.Minute;
        }

        private void numericUpDownAlm_ValueChanged(object sender, EventArgs e)
        {
            radioButtonAlarm.Checked = true;
        }

        private void numericUpDownTim_ValueChanged(object sender, EventArgs e)
        {
            radioButtonTimer.Checked = true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonAlarm.Checked == true)
            {
                // アラーム時刻の設定
                alarmHour = (int)numericUpDownAlmHour.Value;
                alarmMinute = (int)numericUpDownAlmMnt.Value;
                alarmSecond = 0;
            }
            else
            {
                // タイマー時間を現在時刻に加算してアラーム時刻に設定
                DateTime dtNow = DateTime.Now;
                TimeSpan addSpan =
                    new TimeSpan(0, (int)numericUpDownTimMnt.Value,
                                    (int)numericUpDownTimSec.Value);
                DateTime setTime = dtNow.Add(addSpan);
                alarmHour = setTime.Hour;
                alarmMinute = setTime.Minute;
                alarmSecond = setTime.Second;
            }
        }
    }
}
