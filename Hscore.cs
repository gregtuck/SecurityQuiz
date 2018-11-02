using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SecurityQuiz
{
    class Hscore
    {
        protected string rankedPlayer;
        protected int rankedScore;

        List<Hscore> highScores = new List<Hscore>();

        public Hscore[] highscoreArr = new Hscore[5];

        DB connect = new DB();

        public string getrankedPlayer()
        {
            return rankedPlayer;
        }

        public int getrankedScore()
        {
            return rankedScore;
        }

        public void addHStoDB(string playerName, int playerScore)
        {
            try
            {
                SqlConnection con = connect.connection;
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO GAMESEC_APP.HIGHSCORES (playername, score) values (@value1, @value2)", con);
               
                cmd.Parameters.AddWithValue("@value1", playerName);
                cmd.Parameters.AddWithValue("@value2", playerScore);
                cmd.ExecuteNonQuery();
                con.Close();

            }catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Could not insert high score");
            }
        }

        public void getHighScores()
        {
            SqlConnection con = connect.connection;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 5 playername, score FROM GAMESEC_APP.HIGHSCORES ORDER BY score DESC", con);
                SqlDataReader sdl = cmd.ExecuteReader();

                while (sdl.Read())
                {
                    Hscore player = new Hscore();
                    player.rankedPlayer = sdl[0].ToString();
                    player.rankedScore = (int)sdl[1];

                    highScores.Add(player);                
                }
                highscoreArr = highScores.ToArray();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Could not get high scores");
            }
        }
    }
}
