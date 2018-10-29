using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SecurityQuiz
{
    class Question
    {
        protected int questionID;
        protected string option1;
        protected string option2;
        protected string question;
        protected string answer;

        public int getQuestionID()
        {
            return questionID;
        }

        public string getOption1()
        {
            return option1;
        }

        public string getOption2()
        {
            return option2;
        }

        public string getQuestion()
        {
            return question;
        }

        public string getAnswer()
        {
            return answer;
        }

        public void fetchQuestion()
        {
            DB connect = new DB();
            Random rnd = new Random();

            questionID = rnd.Next(1, 10);            

            SqlConnection con = connect.connection;

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM GAMESEC_APP.QUESTIONS WHERE question_id ='" + questionID + "'", con);
            SqlDataReader sdl = cmd.ExecuteReader();
            while (sdl.Read())
            {
                // change default values to show as text from question datatable
                question = sdl[1].ToString();
                option1 = sdl[2].ToString();
                option2 = sdl[3].ToString();
                answer = sdl[6].ToString();
            }
            con.Close();
        }       
    }
}
