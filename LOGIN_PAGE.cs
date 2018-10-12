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
    public partial class LOGIN_PAGE : Form
    {
        public LOGIN_PAGE()
        {
            InitializeComponent();            
        }        
        private void loginButton_Click(object sender, EventArgs e)
        {
            string pass = passwordInput.Text;

            if (passwordInput.TextLength < 8)
            {
               
                BADPASS badPassword = new BADPASS(usernameInput.Text, passwordInput.Text);
                badPassword.Show();                
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source = vmwsql07.uad.ac.uk; Initial Catalog = sql1601097; User ID = sql1601097; Password = JQD1+v==");

                    con.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO GAMESEC_APP.USERS (username, passw) values (@value1, @value2)", con);

                    cmd.Parameters.AddWithValue("value1", usernameInput.Text);
                    cmd.Parameters.AddWithValue("value2", passwordInput.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("could not insert new user");                   
                }
            }
        }
    }
}
