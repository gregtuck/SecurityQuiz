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
        public MainLogin()
        {
            InitializeComponent();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = vmwsql07.uad.ac.uk; Initial Catalog = sql1601097; User ID = sql1601097; Password = JQD1+v==");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT userid, username, passw FROM GAMESEC_APP.USERS WHERE username = '" + USERNAME.Text + "' AND passw = '" + PASSWORD.Text + "'", con);


            con.Open();

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
