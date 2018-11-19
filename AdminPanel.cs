using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SecurityQuiz
{
    public partial class AdminPanel : Form
    {
        DB connect = new DB();

        Admin admin = new Admin();

        string addquestion;
        string addoption1;
        string addoption2;
        string addanswer;
        int QuestionID;

        Question editQuestion = new Question();

        public AdminPanel()
        {
            InitializeComponent();
            showQuestions();
        }
        private void showQuestions()
        {
            DB connect = new DB();
            SqlConnection con = connect.connection;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM GAMESEC_APP.QUESTIONS", con);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bind = new BindingSource();
                bind.DataSource = dt;
                dataGridView1.DataSource = bind;
                sda.Update(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("could not show table");
            }
        }
        private void AddNewQuestion_Click(object sender, EventArgs e)
        {
            addquestion = addQuestionT.Text;
            addoption1 = AddOption1.Text;
            addoption2 = AddOption2.Text;
            addanswer = addAnswer.Text;        
            admin.addQuestion(addquestion, addoption1, addoption2, addanswer);        
            showQuestions();
            Utilities.ResetAllControls(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuestionID = int.Parse(QID.Text);
            admin.deleteQuestion(QuestionID);
            showQuestions();
            Utilities.ResetAllControls(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {        
            QuestionID = int.Parse(QID.Text);
            editQuestion = editQuestion.fetchQuestion(QuestionID);
            addQuestionT.Text = editQuestion.getQuestion();
            AddOption1.Text = editQuestion.getOption1();
            AddOption2.Text = editQuestion.getOption2();
            addAnswer.Text = editQuestion.getAnswer();            
        }

        private void UpdateQuestion_Click(object sender, EventArgs e)
        {
            addquestion = addQuestionT.Text;
            addoption1 = AddOption1.Text;
            addoption2 = AddOption2.Text;
            addanswer = addAnswer.Text;
            QuestionID = int.Parse(QID.Text);
            admin.editQuestion(addquestion, addoption1, addoption2, addanswer, QuestionID);
            showQuestions();
            Utilities.ResetAllControls(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLogin ml = new MainLogin();
            ml.Show();
            ml.Closed += (s, args) => Close();

        }
    }
}
