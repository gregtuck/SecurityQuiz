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

        int gameScore;
        
        

        
        

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
            

            gameScore += 25;          
            Reputation += 10;
            virus -= 10;
            virusScore.Text = virus.ToString();
            reputationScore.Text = Reputation.ToString();
            scorebox.Text = gameScore.ToString();
        }

        public void changeScoreVir()
            
        {

           
            Reputation -= 10;
            virus += 10;
            virusScore.Text = virus.ToString();
            reputationScore.Text = Reputation.ToString();
            scorebox.Text = gameScore.ToString();
        }

        public void getQuestions()
        {
            try
            {
               
                Question qston = new Question();

                qston.fetchQuestion();
                Question.Text = qston.getQuestion();
                button1.Text = qston.getOption1();
                button2.Text = qston.getOption2();
                answer = qston.getAnswer();               
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
            gameScore = 0;
            virusScore.Text = virus.ToString();
            reputationScore.Text = Reputation.ToString();
            scorebox.Text = gameScore.ToString();
        }
        private void PLAY_Load(object sender, EventArgs e)
        {            
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
