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
        //Hscore hs = new Hscore();
        public MainLogin()
        {
            InitializeComponent();                    
        }
        private void LOGIN_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = connect.connection;
            SqlDataAdapter sda = new SqlDataAdapter("SELECT userid, username, passw, userType FROM GAMESEC_APP.USERS WHERE username = '" + USERNAME.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND passw = '" + PASSWORD.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS", con);           
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {// if admin user is logged in the application will show all Main menu Elements
                if (dt.Rows[0][3].ToString() == "1")
                {
                    this.Hide();
                    AdminPanel ap = new AdminPanel();
                    ap.Show();
                    ap.Closed += (s, args) => Close();

                }
                else if (dt.Rows[0][3].ToString() == "0")
                {// if regular User is logged in the Admin button element is hidden to prevent unautherised access
                    this.Hide();
                    MainMenu menu = new MainMenu();
                    menu.Show();
                    menu.Closed += (s, args) => Close();
                   
                }

                
            }
            else
            {
                MessageBox.Show("incorrect username/password");
            }
            con.Close();

            
        }
    }
}
