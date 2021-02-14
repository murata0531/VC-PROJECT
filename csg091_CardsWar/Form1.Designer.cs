namespace csg091_CardsWar
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
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelGuidance = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.labelCompScore = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelComp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(375, 370);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonRestart.TabIndex = 11;
            this.buttonRestart.Text = "再挑戦(&R)";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click_1);
            // 
            // labelGuidance
            // 
            this.labelGuidance.AutoSize = true;
            this.labelGuidance.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelGuidance.ForeColor = System.Drawing.Color.Coral;
            this.labelGuidance.Location = new System.Drawing.Point(130, 160);
            this.labelGuidance.Name = "labelGuidance";
            this.labelGuidance.Size = new System.Drawing.Size(52, 16);
            this.labelGuidance.TabIndex = 10;
            this.labelGuidance.Text = "label3";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPlayerScore.Location = new System.Drawing.Point(15, 275);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(85, 19);
            this.labelPlayerScore.TabIndex = 9;
            this.labelPlayerScore.Text = "得点 ： 0";
            // 
            // labelCompScore
            // 
            this.labelCompScore.AutoSize = true;
            this.labelCompScore.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompScore.Location = new System.Drawing.Point(15, 60);
            this.labelCompScore.Name = "labelCompScore";
            this.labelCompScore.Size = new System.Drawing.Size(85, 19);
            this.labelCompScore.TabIndex = 7;
            this.labelCompScore.Text = "得点 ： 0";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelPlayer.Location = new System.Drawing.Point(15, 245);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(59, 19);
            this.labelPlayer.TabIndex = 8;
            this.labelPlayer.Text = "あなた";
            // 
            // labelComp
            // 
            this.labelComp.AutoSize = true;
            this.labelComp.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelComp.Location = new System.Drawing.Point(15, 30);
            this.labelComp.Name = "labelComp";
            this.labelComp.Size = new System.Drawing.Size(98, 19);
            this.labelComp.TabIndex = 6;
            this.labelComp.Text = "コンピュータ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(814, 401);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelGuidance);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.labelCompScore);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelComp);
            this.Name = "Form1";
            this.Text = "戦争ゲーム";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelGuidance;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.Label labelCompScore;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelComp;
    }
}

