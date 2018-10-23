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
       
        String answer = " ";

        Random rnd = new Random();

        int question;
        int virus;
        int Reputation;

        

        //if the question is odd or even then the respective function is called to change virus/Reputation scores
        public void decider(string response)
        {
            if (response == answer)
            {
                changeScoreRep();
            }
            else 
            {
                changeScoreVir();
            }

            
        }       

        // checks if player has gone too high or low
        public void loseCheck()
        {
            if (virus >= 100)
            {
                Demise dm = new Demise();

                dm.fetchDemise();

                string demiseT = dm.getdemiseText();

                MessageBox.Show(demiseT.ToString());

                //MessageBox.Show("You Lose");

            }
            else if (Reputation >=100)
            {
                MessageBox.Show("You win");
                
            }
        }

        // selects a random question number before calling the function for the SQL query, also ensures that no questions are repeated after the other
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

        public void changeScoreRep()
        {
            int alterVirusNeg = 10;
            int alterReputationNeg = 10;

            

            Reputation += alterReputationNeg;
            virus -= alterVirusNeg;
            virusScore.Text = virus.ToString();
            reputationScore.Text = Reputation.ToString();
        }

        public void changeScoreVir()
            
        {
            int alterReputation = 10;
            int alterVirus = 10;

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
                    Question.Text = sdl[1].ToString();
                    button1.Text = sdl[2].ToString();
                    button2.Text = sdl[3].ToString();

                    answer = sdl[6].ToString();
                }
                con.Close();
                
                
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
            
            decider(button1.Text);
            loseCheck();
            getQuestions();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decider(button2.Text);
            loseCheck();
            getQuestions();
        }
    }
}
