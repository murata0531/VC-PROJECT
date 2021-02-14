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
    public partial class FormSettings : Form
    {
        internal int alarmHour = 0;       // アラーム時
        internal int alarmMinute = 0;     // アラーム分

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            numericUpDownH.Value = DateTime.Now.Hour;
            numericUpDownM.Value = DateTime.Now.Minute;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            alarmHour = (int)numericUpDownH.Value;
            alarmMinute = (int)numericUpDownM.Value;
        }
    }
}
