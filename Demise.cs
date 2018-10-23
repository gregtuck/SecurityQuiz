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


        public int getdemiseID()
        {
            return demiseID;
        }

        public string getdemiseText()
        {
            return demiseText;
        }

        public void fetchDemise()
        {
            //DB conn = new DB();

            Random rnd = new Random();

            demiseID = rnd.Next(1, 6);

            SqlConnection con = new SqlConnection(@"Data Source = vmwsql07.uad.ac.uk; Initial Catalog = sql1601097; User ID = sql1601097; Password = JQD1+v==");


            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT demiseText FROM GAMESEC_APP.DEMISE WHERE demiseID ='" + demiseID + "'", con );

            SqlDataReader sdl = cmd.ExecuteReader();

            while (sdl.Read())
            {           
                demiseText = sdl[0].ToString();
            }

            con.Close();

            






        }


    }
}
