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
    public partial class HighScore : Form
    {
        Hscore HS = new Hscore();
        int PlayerScoretosubmit;
        string PlayerName;


        public HighScore(int playerScore)
        {
            InitializeComponent();
            PHScore.Text = playerScore.ToString();
            PlayerScoretosubmit = playerScore;
            

            

        }

        private void addHScore_Click(object sender, EventArgs e)
        {
            PlayerName = HScoreN.Text;
            HS.addHStoDB(PlayerName, PlayerScoretosubmit);

            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
            mm.Closed += (s, args) => Close();
        }
    }
}
