using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Admin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginEvent(object sender, MouseEventArgs e)
        {
            ////
            //1. create a connection to the database
            //2. retrieve info from input and use it as parameter
            //3.  perform query to the db
            //4. check result and do appropriate action
            //String userName = UserNameTextBox.Text;
            //String passWord = PasswordTextBox.Text;

            //DBConnect dbc = new DBConnect();
            //String query = "Select * from user where Email = '"+userName+"' " +
              //                  "and Password='"+passWord+"'";
            //String result = dbc.checkUser(query);
            //if (result == "")
            //{
            //    MessageBox.Show("Please consult the Admin to activate your account!");
            //}
            //else if (result == null)
            //{
            //    MessageBox.Show("Cannot connect to the Database");
            //}
            //else if (passWord == result)
            //{
                startForm lef = new startForm();
                lef.Show();
                this.Hide();
           // }
           // else
           // {
           //     MessageBox.Show("Credentials are not acceptable!");
           // }
           
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
