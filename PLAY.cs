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
        int virus;
        int Reputation;
        public void decider(int q)
        {
            if (question % 2 == 0)
            {
                changeScore();
            }
            else if (question % 2 == 1)
            {
                changeScoreNeg();
            }
        }       
        public void loseCheck()
        {
            if (virus >= 100 | Reputation >= 100)
            {
                MessageBox.Show("too high");

            }
            else if (virus <=0 | Reputation <=0)
            {
                MessageBox.Show("Too Low");
            }
        }
        public int RandomQ(int lastQuestion)
        {           
            question = rnd.Next(1, 10);

            if (question == lastQuestion)
            {
                return RandomQ(question);
            }
            else
            return question;
        }

        public void changeScoreNeg()
        {
            int alterVirusNeg = 0;
            int alterReputationNeg = 0;

            SqlConnection con = new SqlConnection(@"Data Source = vmwsql07.uad.ac.uk; Initial Catalog = sql1601097; User ID = sql1601097; Password = JQD1+v==");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT reputation, virus FROM GAMESEC_APP.QUESTIONS WHERE question_id ='" + question + "'", con);
            SqlDataReader sdl = cmd.ExecuteReader();

            while (sdl.Read())
            {
                alterReputationNeg = (int)sdl[0];
                alterVirusNeg = (int)sdl[1];
            }
            Reputation += alterReputationNeg;
            virus -= alterVirusNeg;
            virusScore.Text = virus.ToString();
            reputationScore.Text = Reputation.ToString();
        }

        public void changeScore()
        {
            int alterVirus =0;
            int alterReputation =0;

            SqlConnection con = new SqlConnection(@"Data Source = vmwsql07.uad.ac.uk; Initial Catalog = sql1601097; User ID = sql1601097; Password = JQD1+v==");

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT reputation, virus FROM GAMESEC_APP.QUESTIONS WHERE question_id ='" + question + "'", con);
            SqlDataReader sdl = cmd.ExecuteReader();

            while (sdl.Read())
            {
                alterReputation = (int)sdl[0];
                alterVirus = (int)sdl[1];
            }
            Reputation -= alterReputation;
            virus += alterVirus;
            virusScore.Text = virus.ToString();
            reputationScore.Text = Reputation.ToString();
        }

        public void getQuestions()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = vmwsql07.uad.ac.uk; Initial Catalog = sql1601097; User ID = sql1601097; Password = JQD1+v==");

                RandomQ(question);

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
            virus = 50;
            Reputation = 50;
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
            decider(question);
            loseCheck();
            getQuestions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decider(question);
            loseCheck();
            getQuestions();
        }
    }
}
