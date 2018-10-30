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
       
        String answer;
        Random rnd = new Random();
       
        int virus;
        int Reputation;
        int gameScore;
        int question;

        string demiseT;

        

        Demise dm = new Demise();

        Question[] gameQuestions = new Question[10];   
        
        //This function retrieves all the games question objects, places them in an array and retrieves and sets the players demise message
        public string generateGame(string dmse)
        {
            for(int i = 0; i < 10; i++)
            {
                Question getQ = new Question();                
                gameQuestions[i] = getQ.fetchQuestion(i+1);                
            }

            dm.fetchDemise();
            dmse = dm.getdemiseText();
           

            return dmse;
        }               
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

        // checks if the player has either lost or won
        public void loseCheck(string demise)
        {
            if (virus >= 100)
            {

                
                MessageBox.Show(demise.ToString());
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.Show();
                mm.Closed += (s, args) => Close();

            }
            else if (Reputation >=100)
            {
                MessageBox.Show("You win");               
            }
        }

        //ensures that questions are not repeated consecutively 
        public int RandomQ(int lastQuestion)
        {           
            question = rnd.Next(0, 10);

            if (question == lastQuestion)
            {
                return RandomQ(question);
            }
            else
            return question;
        }

        // change players reputation score and lowers virus score
        public void changeScoreRep()
        {           
            gameScore += 25;          
            Reputation += 10;
            virus -= 10;           
            virusScore.Text = virus.ToString();
            reputationScore.Text = Reputation.ToString();
            scorebox.Text = gameScore.ToString();           
        }

        // change players virus score and lowers reputation score
        public void changeScoreVir()
            
        {          
            Reputation -= 10;
            virus += 10;            
            virusScore.Text = virus.ToString();
            reputationScore.Text = Reputation.ToString();
            scorebox.Text = gameScore.ToString();          
        }

        // get game questions from the array of questions objects
        public void getQuestions()
        {
            try
            {
                RandomQ(question);
                Question.Text = gameQuestions[question].getQuestion();
                button1.Text = gameQuestions[question].getOption1();
                button2.Text = gameQuestions[question].getOption2();
                answer = gameQuestions[question].getAnswer();                                          
            }
            catch (Exception)
            {
                MessageBox.Show("Could not retrieve Question");
            }
        }

        //game setup
        public PLAY()
        {          
            InitializeComponent();
            demiseT = generateGame(demiseT);
            virus = 50;
            Reputation = 50;
            gameScore = 0;
            question = RandomQ(0);
            virusScore.Text = virus.ToString();
            reputationScore.Text = Reputation.ToString();
            scorebox.Text = gameScore.ToString();

        }

        //after player has answered question The PLAY form will reload retrieving questions
        private void PLAY_Load(object sender, EventArgs e)
        {           
            getQuestions();
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            decider(button1.Text);
            loseCheck(demiseT);
            getQuestions();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            decider(button2.Text);
            loseCheck(demiseT);           
            getQuestions();
            
        }
    }
}
