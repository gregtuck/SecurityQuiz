namespace SecurityQuiz
{
    partial class AdminPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.addQuestionT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOption1 = new System.Windows.Forms.TextBox();
            this.AddOption2 = new System.Windows.Forms.TextBox();
            this.AddNewQuestion = new System.Windows.Forms.Button();
            this.QID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UpdateQuestion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.addAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question";
            // 
            // addQuestionT
            // 
            this.addQuestionT.Location = new System.Drawing.Point(9, 36);
            this.addQuestionT.Multiline = true;
            this.addQuestionT.Name = "addQuestionT";
            this.addQuestionT.Size = new System.Drawing.Size(191, 60);
            this.addQuestionT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Option 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Option 2";
            // 
            // AddOption1
            // 
            this.AddOption1.Location = new System.Drawing.Point(9, 119);
            this.AddOption1.Name = "AddOption1";
            this.AddOption1.Size = new System.Drawing.Size(191, 20);
            this.AddOption1.TabIndex = 6;
            // 
            // AddOption2
            // 
            this.AddOption2.Location = new System.Drawing.Point(9, 169);
            this.AddOption2.Name = "AddOption2";
            this.AddOption2.Size = new System.Drawing.Size(191, 20);
            this.AddOption2.TabIndex = 7;
            // 
            // AddNewQuestion
            // 
            this.AddNewQuestion.Location = new System.Drawing.Point(14, 254);
            this.AddNewQuestion.Name = "AddNewQuestion";
            this.AddNewQuestion.Size = new System.Drawing.Size(100, 61);
            this.AddNewQuestion.TabIndex = 8;
            this.AddNewQuestion.Text = "ADD";
            this.AddNewQuestion.UseVisualStyleBackColor = true;
            this.AddNewQuestion.Click += new System.EventHandler(this.AddNewQuestion_Click);
            // 
            // QID
            // 
            this.QID.Location = new System.Drawing.Point(6, 42);
            this.QID.Name = "QID";
            this.QID.Size = new System.Drawing.Size(100, 20);
            this.QID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Question ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "REMOVE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UpdateQuestion
            // 
            this.UpdateQuestion.Location = new System.Drawing.Point(9, 163);
            this.UpdateQuestion.Name = "UpdateQuestion";
            this.UpdateQuestion.Size = new System.Drawing.Size(100, 61);
            this.UpdateQuestion.TabIndex = 14;
            this.UpdateQuestion.Text = "SUBMIT CHANGE";
            this.UpdateQuestion.UseVisualStyleBackColor = true;
            this.UpdateQuestion.Click += new System.EventHandler(this.UpdateQuestion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Answer";
            // 
            // addAnswer
            // 
            this.addAnswer.Location = new System.Drawing.Point(11, 210);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(191, 20);
            this.addAnswer.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addQuestionT);
            this.groupBox1.Controls.Add(this.addAnswer);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AddOption1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AddOption2);
            this.groupBox1.Controls.Add(this.AddNewQuestion);
            this.groupBox1.Location = new System.Drawing.Point(607, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 356);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Question";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.QID);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.UpdateQuestion);
            this.groupBox2.Location = new System.Drawing.Point(841, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 230);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove or Add Question";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1055, 418);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addQuestionT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddOption1;
        private System.Windows.Forms.TextBox AddOption2;
        private System.Windows.Forms.Button AddNewQuestion;
        private System.Windows.Forms.TextBox QID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button UpdateQuestion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}