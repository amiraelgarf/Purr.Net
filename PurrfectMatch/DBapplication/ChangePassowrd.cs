using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace DBapplication
{
    public partial class ChangePassowrd : Form
    {
        string Username;
        Controller controllerObj;
        public ChangePassowrd(string username)
        {
            InitializeComponent();
            Username = username;
            controllerObj = new Controller();
            password.PasswordChar = '*';
            confirmPassword.PasswordChar = '*';
        }
        private void changePassword_Click(object sender, EventArgs e)
        {
            if (password.Text == "" || confirmPassword.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {

                if(string.Equals(password.Text, confirmPassword.Text))
                {
                    int r = controllerObj.ChangePassword(Username, confirmPassword.Text);
                    if (r == 0)
                    {
                        MessageBox.Show("Please, insert values correctly");
                    }
                    else
                    {
                        MessageBox.Show("password updated successfully");
                    }
                }
                else
                {
                    MessageBox.Show("please confirm the password correctly");
                }



            }

        }
    }
}
