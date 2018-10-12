namespace SecurityQuiz
{
    partial class BADPASS
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
            this.BPmessage = new System.Windows.Forms.Label();
            this.answerNo = new System.Windows.Forms.Button();
            this.answerYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BPmessage
            // 
            this.BPmessage.AutoSize = true;
            this.BPmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPmessage.Location = new System.Drawing.Point(12, 25);
            this.BPmessage.Name = "BPmessage";
            this.BPmessage.Size = new System.Drawing.Size(429, 18);
            this.BPmessage.TabIndex = 0;
            this.BPmessage.Text = "Your Password is too short would you like to change it?";
            // 
            // answerNo
            // 
            this.answerNo.Location = new System.Drawing.Point(66, 104);
            this.answerNo.Name = "answerNo";
            this.answerNo.Size = new System.Drawing.Size(117, 58);
            this.answerNo.TabIndex = 1;
            this.answerNo.Text = "NO";
            this.answerNo.UseVisualStyleBackColor = true;
            this.answerNo.Click += new System.EventHandler(this.answerNo_Click);
            // 
            // answerYes
            // 
            this.answerYes.Location = new System.Drawing.Point(275, 104);
            this.answerYes.Name = "answerYes";
            this.answerYes.Size = new System.Drawing.Size(120, 58);
            this.answerYes.TabIndex = 2;
            this.answerYes.Text = "YES";
            this.answerYes.UseVisualStyleBackColor = true;
            this.answerYes.Click += new System.EventHandler(this.answerYes_Click);
            // 
            // BADPASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 235);
            this.Controls.Add(this.answerYes);
            this.Controls.Add(this.answerNo);
            this.Controls.Add(this.BPmessage);
            this.Name = "BADPASS";
            this.Text = "BADPASS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BPmessage;
        private System.Windows.Forms.Button answerNo;
        private System.Windows.Forms.Button answerYes;
    }
}