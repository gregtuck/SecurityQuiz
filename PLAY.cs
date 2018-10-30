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

        Question[] gameQuestions = new Question[10];     
        public void generateQuestions()
        {
            for(int i = 0; i < 10; i++)
            {
                Question getQ = new Question();                
                gameQuestions[i] = getQ.fetchQuestion(i+1);                
            }
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
        public void loseCheck()
        {
            if (virus >= 100)
            {
                Demise dm = new Demise();
                dm.fetchDemise();
                string demiseT = dm.getdemiseText();
                MessageBox.Show(demiseT.ToString());               
            }
            else if (Reputation >=100)
            {
                MessageBox.Show("You win");               
            }
        }       
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
        public PLAY()
        {          
            InitializeComponent();
            generateQuestions();

            virus = 50;
            Reputation = 50;
            gameScore = 0;
            question = RandomQ(0);
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
