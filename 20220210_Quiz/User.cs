using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220210_Quiz
{
    public class User
    {
        private string _user_name;
        private string _password;

        public string UserName
        {
            get { return _user_name; }
            set { _user_name = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public User(string user_name,string password)
        {
            this.UserName = user_name;
            this.Password = password;
        }
    }
}
