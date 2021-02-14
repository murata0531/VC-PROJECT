namespace csg060_AlarmTimer
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownAlmMnt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimSec = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimMnt = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlmHour = new System.Windows.Forms.NumericUpDown();
            this.radioButtonTimer = new System.Windows.Forms.RadioButton();
            this.radioButtonAlarm = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmMnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimMnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmHour)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(152, 170);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 32);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "キャンセル(&C)";
            this.buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(41, 170);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(78, 32);
            this.buttonOK.TabIndex = 11;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(241, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "秒後";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(241, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "分";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "時";
            // 
            // numericUpDownAlmMnt
            // 
            this.numericUpDownAlmMnt.Location = new System.Drawing.Point(41, 114);
            this.numericUpDownAlmMnt.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownAlmMnt.Name = "numericUpDownAlmMnt";
            this.numericUpDownAlmMnt.Size = new System.Drawing.Size(69, 19);
            this.numericUpDownAlmMnt.TabIndex = 4;
            this.numericUpDownAlmMnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownTimSec
            // 
            this.numericUpDownTimSec.Location = new System.Drawing.Point(167, 114);
            this.numericUpDownTimSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownTimSec.Name = "numericUpDownTimSec";
            this.numericUpDownTimSec.Size = new System.Drawing.Size(69, 19);
            this.numericUpDownTimSec.TabIndex = 9;
            this.numericUpDownTimSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownTimMnt
            // 
            this.numericUpDownTimMnt.Location = new System.Drawing.Point(167, 73);
            this.numericUpDownTimMnt.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownTimMnt.Name = "numericUpDownTimMnt";
            this.numericUpDownTimMnt.Size = new System.Drawing.Size(69, 19);
            this.numericUpDownTimMnt.TabIndex = 7;
            this.numericUpDownTimMnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownAlmHour
            // 
            this.numericUpDownAlmHour.Location = new System.Drawing.Point(41, 73);
            this.numericUpDownAlmHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownAlmHour.Name = "numericUpDownAlmHour";
            this.numericUpDownAlmHour.Size = new System.Drawing.Size(69, 19);
            this.numericUpDownAlmHour.TabIndex = 2;
            this.numericUpDownAlmHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButtonTimer
            // 
            this.radioButtonTimer.AutoSize = true;
            this.radioButtonTimer.ForeColor = System.Drawing.Color.White;
            this.radioButtonTimer.Location = new System.Drawing.Point(167, 41);
            this.radioButtonTimer.Name = "radioButtonTimer";
            this.radioButtonTimer.Size = new System.Drawing.Size(74, 16);
            this.radioButtonTimer.TabIndex = 5;
            this.radioButtonTimer.Text = "タイマー(&T)";
            this.radioButtonTimer.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlarm
            // 
            this.radioButtonAlarm.AutoSize = true;
            this.radioButtonAlarm.Checked = true;
            this.radioButtonAlarm.ForeColor = System.Drawing.Color.White;
            this.radioButtonAlarm.Location = new System.Drawing.Point(21, 41);
            this.radioButtonAlarm.Name = "radioButtonAlarm";
            this.radioButtonAlarm.Size = new System.Drawing.Size(76, 16);
            this.radioButtonAlarm.TabIndex = 0;
            this.radioButtonAlarm.TabStop = true;
            this.radioButtonAlarm.Text = "アラーム(&A)";
            this.radioButtonAlarm.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownAlmMnt);
            this.Controls.Add(this.numericUpDownTimSec);
            this.Controls.Add(this.numericUpDownTimMnt);
            this.Controls.Add(this.numericUpDownAlmHour);
            this.Controls.Add(this.radioButtonTimer);
            this.Controls.Add(this.radioButtonAlarm);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmMnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimMnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlmHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownAlmMnt;
        private System.Windows.Forms.NumericUpDown numericUpDownTimSec;
        private System.Windows.Forms.NumericUpDown numericUpDownTimMnt;
        private System.Windows.Forms.NumericUpDown numericUpDownAlmHour;
        private System.Windows.Forms.RadioButton radioButtonTimer;
        private System.Windows.Forms.RadioButton radioButtonAlarm;
    }
}