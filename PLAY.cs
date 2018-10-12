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
    
    public partial class PLAY : Form
    {
        // initialise string variables as default
        string question_text = "Did not work :(";
        string button1_text = "did not show";
        string button2_text = "did not show";

        Random rnd = new Random();

        int question;

        int virus = 50;

        int Reputation = 50;

        


        public int RandomQ()
        {
            question = rnd.Next(1, 9);

            return question;
        }

        public void changeScore()
        {
            SqlConnection con = new SqlConnection(@"Data Source = vmwsql07.uad.ac.uk; Initial Catalog = sql1601097; User ID = sql1601097; Password = JQD1+v==");
            con.Open();



        }

        public void getQuestions()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = vmwsql07.uad.ac.uk; Initial Catalog = sql1601097; User ID = sql1601097; Password = JQD1+v==");

                RandomQ();

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM GAMESEC_APP.QUESTIONS WHERE question_id ='" + question + "'", con);
                SqlDataReader sdl = cmd.ExecuteReader();
                while (sdl.Read())
                {
                    // change default values to show as text from question datatable
                    question_text = sdl[1].ToString();
                    button1_text = sdl[2].ToString();
                    button2_text = sdl[3].ToString();
                }

                con.Close();

                Question.Text = question_text;
                button1.Text = button1_text;
                button2.Text = button2_text;
            }
            catch (Exception)
            {
            }

        }



        public PLAY()
        {
            InitializeComponent();

            virusScore.Text = virus.ToString();
            reputationScore.Text = Reputation.ToString();
            
           
        }

       

        private void PLAY_Load(object sender, EventArgs e)
        {

            //RandomNumber randomNumber(int min, int max);

            getQuestions();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getQuestions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getQuestions();
        }
    }
}
