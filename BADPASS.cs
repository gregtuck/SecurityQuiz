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
    public partial class BADPASS : Form
    {
        public string uname;
        public string pas;

        public BADPASS(string username, string password)
        {
            InitializeComponent();
            uname = username;
            pas = password;           
        }
        private void answerYes_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
        private void answerNo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = vmwsql07.uad.ac.uk; Initial Catalog = sql1601097; User ID = sql1601097; Password = JQD1+v==");

                con.Open();

                // adds the values carried from the previous form
                SqlCommand cmd = new SqlCommand("INSERT INTO GAMESEC_APP.USERS (username, passw) values (@value1, @value2)", con);

                cmd.Parameters.AddWithValue("value1", uname);
                cmd.Parameters.AddWithValue("value2", pas);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("could not insert new user");
            }
        }
    }
}
