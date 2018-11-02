using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityQuiz
{
    public partial class highScoreView : Form
    {
        Hscore hs = new Hscore();


        public highScoreView()
        {
            InitializeComponent();
            hs.getHighScores();
            displayScores();
        }

        public void displayScores()
        {
            try
            {
                firstN.Text = hs.highscoreArr[0].getrankedPlayer().ToString();
                firstScore.Text = hs.highscoreArr[0].getrankedScore().ToString();
                secondN.Text = hs.highscoreArr[1].getrankedPlayer().ToString();
                secondScore.Text = hs.highscoreArr[1].getrankedScore().ToString();
                thirdN.Text = hs.highscoreArr[2].getrankedPlayer().ToString();
                thirdScore.Text = hs.highscoreArr[2].getrankedScore().ToString();
                fourthN.Text = hs.highscoreArr[3].getrankedPlayer().ToString();
                fourthS.Text = hs.highscoreArr[3].getrankedScore().ToString();
                fifthN.Text = hs.highscoreArr[4].getrankedPlayer().ToString();
                fifthScore.Text = hs.highscoreArr[4].getrankedScore().ToString();
            }catch(Exception)
            {
                MessageBox.Show("cannot display highscores");
            }
        }

        
    }
}
