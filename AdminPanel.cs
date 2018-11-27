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
        //show all Questions and scenarios to datatable shown on admin panel
        private void showQuestions()
        {
            try
            {
                DB connect = new DB();
                SqlConnection con = connect.connection;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM GAMESEC_APP.QUESTIONS", con);

            
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
            try {
                addquestion = addQuestionT.Text;
                addoption1 = AddOption1.Text;
                addoption2 = AddOption2.Text;
                addanswer = addAnswer.Text;
                admin.addQuestion(addquestion, addoption1, addoption2, addanswer);
                showQuestions();
                Utilities.ClearPanels(groupBox1);
            } catch (Exception)
            {
                MessageBox.Show("Please Ensure all Fields are valid");
            }
            
           
        }

        //delete question from database
        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (QID.Text == "")
                {
                    MessageBox.Show("no ID entered");
                }
                else
                {
                    QuestionID = int.Parse(QID.Text);
                    admin.deleteQuestion(QuestionID);
                    showQuestions();
                    Utilities.ClearPanels(groupBox2);
                }
            }catch(Exception)
            {
                MessageBox.Show("Please Ensure input is valid ID");
            }
            
        }

        //edit question on database
        private void button3_Click(object sender, EventArgs e)
        {
            try {
                QuestionID = int.Parse(QID.Text);
                editQuestion = editQuestion.fetchQuestion(QuestionID);
                addQuestionT.Text = editQuestion.getQuestion();
                AddOption1.Text = editQuestion.getOption1();
                AddOption2.Text = editQuestion.getOption2();
                addAnswer.Text = editQuestion.getAnswer();
            }catch(Exception)
            {
                MessageBox.Show("Please ensure field is not empty");
            }
                   
        }

        //update question on database
        private void UpdateQuestion_Click(object sender, EventArgs e)
        {
            try { addquestion = addQuestionT.Text;
                addoption1 = AddOption1.Text;
                addoption2 = AddOption2.Text;
                addanswer = addAnswer.Text;
                QuestionID = int.Parse(QID.Text);
                admin.editQuestion(addquestion, addoption1, addoption2, addanswer, QuestionID);
                showQuestions();
                Utilities.ClearPanels(groupBox1);
            }
            catch(Exception)
            {
                MessageBox.Show("Please Ensure all Fields are valid");
            }
            
        }

        //logout button 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainLogin ml = new MainLogin();
            ml.Show();
            ml.Closed += (s, args) => Close();

        }

       
    }
}
