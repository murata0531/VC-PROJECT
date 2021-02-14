namespace csg041_WeekOfDay
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
            this.labelY = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelW = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownD = new System.Windows.Forms.NumericUpDown();
            this.buttonGet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD)).BeginInit();
            this.SuspendLayout();
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(27, 26);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(44, 12);
            this.labelY.TabIndex = 0;
            this.labelY.Text = "西暦(&Y)";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(138, 26);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(34, 12);
            this.labelM.TabIndex = 2;
            this.labelM.Text = "月(&M)";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(245, 26);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(33, 12);
            this.labelD.TabIndex = 4;
            this.labelD.Text = "日(&D)";
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Location = new System.Drawing.Point(323, 49);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(79, 12);
            this.labelW.TabIndex = 6;
            this.labelW.Text = "あり得ない日付";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(29, 46);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(70, 19);
            this.textBoxY.TabIndex = 1;
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(140, 46);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(63, 19);
            this.numericUpDownM.TabIndex = 3;
            this.numericUpDownM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownD
            // 
            this.numericUpDownD.Location = new System.Drawing.Point(247, 46);
            this.numericUpDownD.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownD.Name = "numericUpDownD";
            this.numericUpDownD.Size = new System.Drawing.Size(56, 19);
            this.numericUpDownD.TabIndex = 5;
            this.numericUpDownD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(29, 110);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(373, 23);
            this.buttonGet.TabIndex = 7;
            this.buttonGet.Text = "曜日算出(&G)";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 157);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.numericUpDownD);
            this.Controls.Add(this.numericUpDownM);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelY);
            this.Name = "Form1";
            this.Text = "曜日算出";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.NumericUpDown numericUpDownD;
        private System.Windows.Forms.Button buttonGet;
    }
}

