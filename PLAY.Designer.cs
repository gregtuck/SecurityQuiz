namespace SecurityQuiz
{
    partial class PLAY
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
            this.Question = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.virusScore = new System.Windows.Forms.TextBox();
            this.reputationScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(203, 108);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(0, 13);
            this.Question.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Virus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reputation";
            // 
            // virusScore
            // 
            this.virusScore.Location = new System.Drawing.Point(124, 39);
            this.virusScore.Name = "virusScore";
            this.virusScore.Size = new System.Drawing.Size(27, 20);
            this.virusScore.TabIndex = 5;
            // 
            // reputationScore
            // 
            this.reputationScore.Location = new System.Drawing.Point(579, 39);
            this.reputationScore.Name = "reputationScore";
            this.reputationScore.Size = new System.Drawing.Size(27, 20);
            this.reputationScore.TabIndex = 6;
            // 
            // PLAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reputationScore);
            this.Controls.Add(this.virusScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Question);
            this.Name = "PLAY";
            this.Text = "PLAY";
            this.Load += new System.EventHandler(this.PLAY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox virusScore;
        private System.Windows.Forms.TextBox reputationScore;
    }
}