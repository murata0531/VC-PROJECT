namespace csg071_SwimmingSchedule
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelMonthlyFee = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelClassDays = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.label1Year = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 12;
            this.listBoxCourse.Items.AddRange(new object[] {
            "ベビーコース",
            "幼児コース",
            "小学生コース",
            "中学生コース",
            "レディースコース",
            "一般コース",
            "家族コース"});
            this.listBoxCourse.Location = new System.Drawing.Point(208, 28);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(120, 88);
            this.listBoxCourse.TabIndex = 4;
            this.listBoxCourse.SelectedIndexChanged += new System.EventHandler(this.numericUpDownYear_ValueChanged);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(25, 150);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(303, 23);
            this.buttonShow.TabIndex = 8;
            this.buttonShow.Text = "表示(&S)";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labelMonthlyFee
            // 
            this.labelMonthlyFee.AutoSize = true;
            this.labelMonthlyFee.Location = new System.Drawing.Point(23, 124);
            this.labelMonthlyFee.Name = "labelMonthlyFee";
            this.labelMonthlyFee.Size = new System.Drawing.Size(75, 12);
            this.labelMonthlyFee.TabIndex = 7;
            this.labelMonthlyFee.Text = "月謝代       ：";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(23, 95);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(63, 12);
            this.labelStartTime.TabIndex = 6;
            this.labelStartTime.Text = "開始時間 ：";
            // 
            // labelClassDays
            // 
            this.labelClassDays.AutoSize = true;
            this.labelClassDays.Location = new System.Drawing.Point(23, 65);
            this.labelClassDays.Name = "labelClassDays";
            this.labelClassDays.Size = new System.Drawing.Size(63, 12);
            this.labelClassDays.TabIndex = 5;
            this.labelClassDays.Text = "授業日    ：";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(182, 31);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(17, 12);
            this.labelMonth.TabIndex = 3;
            this.labelMonth.Text = "月";
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(23, 28);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownYear.TabIndex = 0;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownYear.ValueChanged += new System.EventHandler(this.numericUpDownYear_ValueChanged);
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(114, 28);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownMonth.TabIndex = 2;
            this.numericUpDownMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMonth.ValueChanged += new System.EventHandler(this.numericUpDownYear_ValueChanged);
            // 
            // label1Year
            // 
            this.label1Year.AutoSize = true;
            this.label1Year.Location = new System.Drawing.Point(89, 31);
            this.label1Year.Name = "label1Year";
            this.label1Year.Size = new System.Drawing.Size(17, 12);
            this.label1Year.TabIndex = 1;
            this.label1Year.Text = "年";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 210);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.labelMonthlyFee);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelClassDays);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.label1Year);
            this.Name = "Form1";
            this.Text = "ＣＳスイミングスクール";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelMonthlyFee;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelClassDays;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.Label label1Year;
    }
}

