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
        protected string option1;
        protected string option2;
        protected string question;
        protected string answer;
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
        // get questions from the game database
        public Question fetchQuestion(int questionID)
        {
            DB connect = new DB();
            Random rnd = new Random();
            Question newQ = new Question();           
            SqlConnection con = connect.connection;

            con.Open();   
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM GAMESEC_APP.QUESTIONS WHERE question_id ='" + questionID + "'", con);
            SqlDataReader sdl = cmd.ExecuteReader();

            while (sdl.Read())
            {              
                newQ.question = sdl[1].ToString();
                newQ.option1 = sdl[2].ToString();
                newQ.option2 = sdl[3].ToString();
                newQ.answer = sdl[4].ToString();
            }
            con.Close();
            return newQ;           
        }
        
        //return all questions in an array structure
        public Question[] FetchAll()
        {
            List<Question> listQuestions = new List<Question>();            
            DB connect = new DB();
            SqlConnection con = connect.connection;

            con.Open();

            SqlCommand cmd = new SqlCommand("Select * FROM GAMESEC_APP.QUESTIONS ORDER BY newid()", con);
            SqlDataReader sdl = cmd.ExecuteReader();

            while (sdl.Read())
            {
                Question Lq = new Question();
                Lq.question = sdl[1].ToString();
                Lq.option1 = sdl[2].ToString();
                Lq.option2 = sdl[3].ToString();
                Lq.answer = sdl[4].ToString();
                listQuestions.Add(Lq);
            }

            Question[] fetchedQuestions = new Question[listQuestions.Count()];
            fetchedQuestions = listQuestions.ToArray();
            con.Close();

            return fetchedQuestions;           
        }
    }
}
