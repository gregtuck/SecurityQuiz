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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT userid, username, passw FROM GAMESEC_APP.USERS WHERE username = '" + USERNAME.Text + "' AND passw = '" + PASSWORD.Text + "'", con);           
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();
                menu.Closed += (s, args) => Close();
            }
            else
            {
                MessageBox.Show("incorrect username/password");
            }
            con.Close();

            
        }
    }
}
