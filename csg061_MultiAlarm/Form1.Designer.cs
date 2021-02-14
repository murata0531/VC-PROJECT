namespace csg061_MultiAlarm
{
    partial class FormClock
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
            this.components = new System.ComponentModel.Container();
            this.buttonSet3 = new System.Windows.Forms.Button();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.buttonSet1 = new System.Windows.Forms.Button();
            this.labelClock = new System.Windows.Forms.Label();
            this.checkBoxAlm1 = new System.Windows.Forms.CheckBox();
            this.checkBoxAlm2 = new System.Windows.Forms.CheckBox();
            this.checkBoxAlm3 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonSet3
            // 
            this.buttonSet3.BackColor = System.Drawing.Color.White;
            this.buttonSet3.Location = new System.Drawing.Point(131, 156);
            this.buttonSet3.Name = "buttonSet3";
            this.buttonSet3.Size = new System.Drawing.Size(63, 23);
            this.buttonSet3.TabIndex = 6;
            this.buttonSet3.Text = "設定(&T)";
            this.buttonSet3.UseVisualStyleBackColor = false;
            this.buttonSet3.Click += new System.EventHandler(this.buttonSet3_Click);
            // 
            // buttonSet2
            // 
            this.buttonSet2.BackColor = System.Drawing.Color.White;
            this.buttonSet2.Location = new System.Drawing.Point(131, 116);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(62, 23);
            this.buttonSet2.TabIndex = 4;
            this.buttonSet2.Text = "設定(&E)";
            this.buttonSet2.UseVisualStyleBackColor = false;
            this.buttonSet2.Click += new System.EventHandler(this.buttonSet2_Click);
            // 
            // buttonSet1
            // 
            this.buttonSet1.BackColor = System.Drawing.Color.White;
            this.buttonSet1.Location = new System.Drawing.Point(131, 76);
            this.buttonSet1.Name = "buttonSet1";
            this.buttonSet1.Size = new System.Drawing.Size(62, 23);
            this.buttonSet1.TabIndex = 2;
            this.buttonSet1.Text = "設定(&S)";
            this.buttonSet1.UseVisualStyleBackColor = false;
            this.buttonSet1.Click += new System.EventHandler(this.buttonSet1_Click);
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.2F);
            this.labelClock.ForeColor = System.Drawing.Color.Cyan;
            this.labelClock.Location = new System.Drawing.Point(43, 27);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(124, 27);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "23:35:30";
            // 
            // checkBoxAlm1
            // 
            this.checkBoxAlm1.AutoSize = true;
            this.checkBoxAlm1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.checkBoxAlm1.ForeColor = System.Drawing.Color.Yellow;
            this.checkBoxAlm1.Location = new System.Drawing.Point(27, 76);
            this.checkBoxAlm1.Name = "checkBoxAlm1";
            this.checkBoxAlm1.Size = new System.Drawing.Size(92, 31);
            this.checkBoxAlm1.TabIndex = 1;
            this.checkBoxAlm1.Text = "00:00";
            this.checkBoxAlm1.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlm2
            // 
            this.checkBoxAlm2.AutoSize = true;
            this.checkBoxAlm2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.checkBoxAlm2.ForeColor = System.Drawing.Color.Yellow;
            this.checkBoxAlm2.Location = new System.Drawing.Point(27, 116);
            this.checkBoxAlm2.Name = "checkBoxAlm2";
            this.checkBoxAlm2.Size = new System.Drawing.Size(92, 31);
            this.checkBoxAlm2.TabIndex = 3;
            this.checkBoxAlm2.Text = "00:00";
            this.checkBoxAlm2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlm3
            // 
            this.checkBoxAlm3.AutoSize = true;
            this.checkBoxAlm3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.checkBoxAlm3.ForeColor = System.Drawing.Color.Yellow;
            this.checkBoxAlm3.Location = new System.Drawing.Point(27, 153);
            this.checkBoxAlm3.Name = "checkBoxAlm3";
            this.checkBoxAlm3.Size = new System.Drawing.Size(92, 31);
            this.checkBoxAlm3.TabIndex = 5;
            this.checkBoxAlm3.Text = "00:00";
            this.checkBoxAlm3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(226, 197);
            this.Controls.Add(this.checkBoxAlm3);
            this.Controls.Add(this.checkBoxAlm2);
            this.Controls.Add(this.checkBoxAlm1);
            this.Controls.Add(this.buttonSet3);
            this.Controls.Add(this.buttonSet2);
            this.Controls.Add(this.buttonSet1);
            this.Controls.Add(this.labelClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormClock";
            this.Text = "アラーム";
            this.Load += new System.EventHandler(this.FormClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSet3;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.Button buttonSet1;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.CheckBox checkBoxAlm1;
        private System.Windows.Forms.CheckBox checkBoxAlm2;
        private System.Windows.Forms.CheckBox checkBoxAlm3;
        private System.Windows.Forms.Timer timer1;
    }
}

