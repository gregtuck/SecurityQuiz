﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace SecurityQuiz
{
    class DB
    {
        SqlConnection connection;

        public string connectionString = "Data Source = vmwsql07.uad.ac.uk; Initial Catalog = sql1601097; User ID = sql1601097; Password = JQD1+v==";
        public DB()
        {
            connection = new SqlConnection(connectionString);
        }

        public void openConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void closeConnnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }

    }
}