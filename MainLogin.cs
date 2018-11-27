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
    public partial class MainLogin : Form
    {
        DB connect = new DB();
        
        public MainLogin()
        {
            InitializeComponent();
        }
        
        private void LOGIN_Click(object sender, EventArgs e)
        {
            try {
                SqlConnection con = connect.connection;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT passw, userType FROM GAMESEC_APP.USERS WHERE username = '" + USERNAME.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count >= 1)
                {

                    var hashed = dt.Rows[0][0].ToString();

                    var userType = dt.Rows[0][1].ToString();

                    //SecurePasswordHasher.Verify returns a boolean, if true this function will continue with the login process
                    if (SecurePasswordHasher.Verify(PASSWORD.Text, hashed))
                    {
                        if (userType == "1")
                        {
                            this.Hide();
                            AdminPanel ap = new AdminPanel();
                            ap.Show();
                            ap.Closed += (s, args) => Close();
                        }
                        else if (userType == "0")
                        {
                            this.Hide();
                            MainMenu menu = new MainMenu();
                            menu.Show();
                            menu.Closed += (s, args) => Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username/Password incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Username/Password incorrect");
                }
            }catch(Exception)
            {
                MessageBox.Show("Test did not work");
            }
        }
    }
}