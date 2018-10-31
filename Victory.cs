using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SecurityQuiz
{
    class Victory
    {
        protected int victoryID;
        protected string victoryMessage;

        DB connect = new DB();

        public int getvictoryID()
        {
            return victoryID;
        }

        public string getvictoryMessage()
        {
            return victoryMessage;
        }

        public void fetchVictoryMessage()
        {
            Random rnd = new Random();
            victoryID = rnd.Next(1, 6);
            SqlConnection con = connect.connection;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT victoryText FROM GAMESEC_APP.VICTORY WHERE victoryID ='" + victoryID + "'", con);
            SqlDataReader sdl = cmd.ExecuteReader();

            while (sdl.Read())
            {
                victoryMessage = sdl[0].ToString();
            }
            con.Close();
        }
        public string getVictoryMessage(string victory)
        {
            fetchVictoryMessage();
            victory = getvictoryMessage();

            return victory;
        }
    }
}
