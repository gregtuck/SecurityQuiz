using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SecurityQuiz
{
    class Demise
    {
        protected int demiseID;
        protected string demiseText;
        DB connect = new DB();
        public int getdemiseID()
        {
            return demiseID;
        }
        public string getdemiseText()
        {
            return demiseText;
        }

        // get the players demise message from the game database
        public string fetchDemise(string dmse)
        {           
            Random rnd = new Random();
            demiseID = rnd.Next(1, 6);           
            SqlConnection con = connect.connection;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT demiseText FROM GAMESEC_APP.DEMISE WHERE demiseID ='" + demiseID + "'", con);
            SqlDataReader sdl = cmd.ExecuteReader();

            while (sdl.Read())
            {
                demiseText = sdl[0].ToString();
            }
            con.Close();

            dmse = getdemiseText();

            return dmse;
        }
        /*public string fetchDemiseMessage(string dmse)
        {
            fetchDemise();
            dmse = getdemiseText();

            return dmse;
        }*/
    }
}