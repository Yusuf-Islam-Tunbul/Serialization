using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace _20220210_Quiz
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();
            CreateUsers();
        }

        void CreateUsers()
        {
            users.Add(new User("admin", "12345"));
            users.Add(new User("ali", "12345"));
            users.Add(new User("veli", "12345"));
        }

        private void log_in_button_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        void LogIn()
        {
            foreach(User user in users)
            {
                if(user.UserName==user_name_textbox.Text && user.Password == password_textbox.Text)
                {
                    Form2 form2 = new Form2(user);
                    form2.Show();
                }
            }
        }
    }
}
