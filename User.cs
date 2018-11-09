using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityQuiz
{
    class User
    {
        protected string username;

        protected string password;


        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }
    }
}
