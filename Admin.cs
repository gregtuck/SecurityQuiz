using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SecurityQuiz
{
    class Admin:User
    {
        DB connect = new DB();
        public void addQuestion(string question, string option1, string option2, string answer)
        {
            try
            {
                if (question == "" || option1 == "" || option2 == "" || answer == "")
                {
                    MessageBox.Show("Invalid Input, Ensure all Fields are filled");
                }
                else
                {
                    SqlConnection con = connect.connection;

                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO GAMESEC_APP.QUESTIONS (question_text, option_1, option_2, answer) values (@value1, @value2, @value3, @value4)", con);

                    cmd.Parameters.AddWithValue("@value1", question);
                    cmd.Parameters.AddWithValue("@value2", option1);
                    cmd.Parameters.AddWithValue("@value3", option2);
                    cmd.Parameters.AddWithValue("@value4", answer);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                }
            }catch(Exception)
            {
                MessageBox.Show("Could not add new question to database");
            }
        }

        public void addUser(string username, string password)
        {
            try
            {
                var hash = SecurePasswordHasher.Hash(password);

                SqlConnection con = connect.connection;

                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO GAMESEC_APP.USERS (username, passw, userType) values (@value1, @value2, @value3)", con);

                cmd.Parameters.AddWithValue("@value1", username);
                cmd.Parameters.AddWithValue("@value2", hash);
                cmd.Parameters.AddWithValue("@value3", 0);
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception)
            {
                MessageBox.Show("Could not add new User");
            }
        }

        public void deleteQuestion (int questionID)
        {
            try
            {
                SqlConnection con = connect.connection;
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM GAMESEC_APP.QUESTIONS WHERE question_id = (@value1)", con);

                cmd.Parameters.AddWithValue("@value1", questionID);
                cmd.ExecuteNonQuery();
                con.Close();

            }catch(Exception)
            {
                MessageBox.Show("Could not remove question");
            }
        }

        public void editQuestion (string q, string one, string two, string a, int qid)
        {          
            try
            {
                if (q == ""||one == ""||two =="" || a=="")
                {
                    MessageBox.Show("Please ensure that all fields are valid");
                }
                SqlConnection con = connect.connection;
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE GAMESEC_APP.QUESTIONS SET question_text = @value1, option_1 = @value2, option_2 = @value3, answer = @value4 WHERE question_id = @value5", con);

                cmd.Parameters.AddWithValue("@value1", q);
                cmd.Parameters.AddWithValue("@value2", one);
                cmd.Parameters.AddWithValue("@value3", two);
                cmd.Parameters.AddWithValue("@value4", a);
                cmd.Parameters.AddWithValue("@value5", qid);

                cmd.ExecuteNonQuery();
                con.Close();

            }catch(Exception)
            {
                MessageBox.Show("Could not update");
            }
            
        }
    }
}
