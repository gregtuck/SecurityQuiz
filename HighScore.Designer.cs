namespace SecurityQuiz
{
    partial class HighScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.HScoreN = new System.Windows.Forms.TextBox();
            this.addHScore = new System.Windows.Forms.Button();
            this.PHScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(90, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HIGHSCORE";
            // 
            // HScoreN
            // 
            this.HScoreN.BackColor = System.Drawing.SystemColors.InfoText;
            this.HScoreN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HScoreN.ForeColor = System.Drawing.Color.Lime;
            this.HScoreN.Location = new System.Drawing.Point(94, 92);
            this.HScoreN.Name = "HScoreN";
            this.HScoreN.Size = new System.Drawing.Size(113, 22);
            this.HScoreN.TabIndex = 1;
            // 
            // addHScore
            // 
            this.addHScore.Location = new System.Drawing.Point(94, 160);
            this.addHScore.Name = "addHScore";
            this.addHScore.Size = new System.Drawing.Size(113, 54);
            this.addHScore.TabIndex = 2;
            this.addHScore.Text = "SUBMIT";
            this.addHScore.UseVisualStyleBackColor = true;
            this.addHScore.Click += new System.EventHandler(this.addHScore_Click);
            // 
            // PHScore
            // 
            this.PHScore.AutoSize = true;
            this.PHScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PHScore.Location = new System.Drawing.Point(101, 53);
            this.PHScore.Name = "PHScore";
            this.PHScore.Size = new System.Drawing.Size(95, 20);
            this.PHScore.TabIndex = 3;
            this.PHScore.Text = "high Score";
            this.PHScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(316, 272);
            this.Controls.Add(this.PHScore);
            this.Controls.Add(this.addHScore);
            this.Controls.Add(this.HScoreN);
            this.Controls.Add(this.label1);
            this.Name = "HighScore";
            this.Text = "HighScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HScoreN;
        private System.Windows.Forms.Button addHScore;
        private System.Windows.Forms.Label PHScore;
    }
}