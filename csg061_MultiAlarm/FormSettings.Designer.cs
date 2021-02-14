namespace csg061_MultiAlarm
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
            this.labelM = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(64, 145);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "キャンセル(&C)";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(64, 116);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(89, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(42, 67);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(34, 12);
            this.labelM.TabIndex = 2;
            this.labelM.Text = "分(&M)";
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.Location = new System.Drawing.Point(42, 31);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(33, 12);
            this.labelH.TabIndex = 0;
            this.labelH.Text = "時(&H)";
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(81, 65);
            this.numericUpDownM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(75, 19);
            this.numericUpDownM.TabIndex = 3;
            this.numericUpDownM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.Location = new System.Drawing.Point(81, 24);
            this.numericUpDownH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(75, 19);
            this.numericUpDownH.TabIndex = 1;
            this.numericUpDownH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 187);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelH);
            this.Controls.Add(this.numericUpDownM);
            this.Controls.Add(this.numericUpDownH);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "時刻設定";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.NumericUpDown numericUpDownH;
    }
}