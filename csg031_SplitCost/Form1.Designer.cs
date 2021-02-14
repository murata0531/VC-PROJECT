namespace csg031_SplitCost
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTaxFreePrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelEachPay = new System.Windows.Forms.Label();
            this.labelShortage = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜き金額(&P)";
            // 
            // textBoxTaxFreePrice
            // 
            this.textBoxTaxFreePrice.Location = new System.Drawing.Point(27, 72);
            this.textBoxTaxFreePrice.Name = "textBoxTaxFreePrice";
            this.textBoxTaxFreePrice.Size = new System.Drawing.Size(100, 19);
            this.textBoxTaxFreePrice.TabIndex = 1;
            this.textBoxTaxFreePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "円";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "人数(&N)";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(188, 72);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(100, 19);
            this.textBoxNum.TabIndex = 4;
            this.textBoxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "人";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "一人あたり";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "不足";
            // 
            // labelEachPay
            // 
            this.labelEachPay.AutoSize = true;
            this.labelEachPay.Location = new System.Drawing.Point(25, 170);
            this.labelEachPay.Name = "labelEachPay";
            this.labelEachPay.Size = new System.Drawing.Size(35, 12);
            this.labelEachPay.TabIndex = 7;
            this.labelEachPay.Text = "label7";
            // 
            // labelShortage
            // 
            this.labelShortage.AutoSize = true;
            this.labelShortage.Location = new System.Drawing.Point(196, 170);
            this.labelShortage.Name = "labelShortage";
            this.labelShortage.Size = new System.Drawing.Size(35, 12);
            this.labelShortage.TabIndex = 9;
            this.labelShortage.Text = "label8";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(85, 212);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(98, 28);
            this.buttonCalc.TabIndex = 10;
            this.buttonCalc.Text = "計算する(&C)";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 261);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelShortage);
            this.Controls.Add(this.labelEachPay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTaxFreePrice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "割り勘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTaxFreePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelEachPay;
        private System.Windows.Forms.Label labelShortage;
        private System.Windows.Forms.Button buttonCalc;
    }
}

