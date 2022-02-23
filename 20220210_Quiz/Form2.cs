using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Input;

namespace _20220210_Quiz
{
    public partial class Form2 : Form
    {
        User active_user_;
        public Form2(User active_user)
        {
            active_user_ = active_user;

            InitializeComponent();

            CreateOrCall(active_user_.UserName);
        }

        void CreateOrCall(string user_name)
        {
            if (File.Exists(Application.StartupPath + $@"\{user_name}.xml"))
            {
                Load_(user_name);                
            }
            else
            {
                Save(user_name, new UserPrefs());
            }
        }

        void Save(string user_name, UserPrefs user_prefs)
        {
            XmlWriter writer = XmlWriter.Create(Application.StartupPath + $@"\{user_name}.xml");

            XmlSerializer xmlserializer = new XmlSerializer(typeof (UserPrefs));

            xmlserializer.Serialize(writer, user_prefs);
            writer.Close();

            this.Width = user_prefs.Width;
            this.Height = user_prefs.Height;
            this.Top = user_prefs.Top;
            this.Left= user_prefs.Left;
        }

        void Load_(string user_name)
        {
            FileStream stream = new FileStream(Application.StartupPath + $@"\{user_name}.xml", FileMode.Open);
            XmlReader reader = XmlReader.Create(stream);
            XmlSerializer xmldeserializer = new XmlSerializer(typeof(UserPrefs));
            UserPrefs user_prefs= (UserPrefs)xmldeserializer.Deserialize(reader);

            this.Size = new Size(user_prefs.Width, user_prefs.Height);
            this.Location = new Point(user_prefs.Left, user_prefs.Top);

            stream.Close();
            reader.Close();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Save(active_user_.UserName, SetValues());
        }

        UserPrefs SetValues()
        {
            UserPrefs user_prefs = new UserPrefs();

            try
            {
                user_prefs.Width =Convert.ToInt32(width_textbox.Text);
            }
            catch
            {
                user_prefs.Width = this.Width;
            }

            try
            {
                user_prefs.Height =Convert.ToInt32(height_textbox.Text);
            }
            catch
            {
                user_prefs.Height = this.Height;
            }

            try
            {
                user_prefs.Left =Convert.ToInt32(left_textbox.Text);
            }
            catch
            {
                user_prefs.Left = this.Left;
            }

            try
            {
                user_prefs.Top =Convert.ToInt32(top_textbox.Text);
            }
            catch
            {
                user_prefs.Top = this.Top;
            }

            return user_prefs;
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            //Save(active_user_.UserName, new UserPrefs(this.Width, this.Height, this.Top, this.Left));
        }
    }
}
