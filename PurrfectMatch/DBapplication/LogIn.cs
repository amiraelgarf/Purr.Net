using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class LogIn : Form
    {
        Controller controllerObj;
        public LogIn()
        {
            InitializeComponent();
            controllerObj = new Controller();
            password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }

            string AccountType = controllerObj.AuthenticateUser(username.Text, password.Text);

            if (AccountType == "")
            {
                MessageBox.Show("Wrong username or password please try agin");
            }
            else if(AccountType== "Customer" || AccountType == "customer")
            {
                Customer c = new Customer(username.Text);
                this.Hide();
                c.ShowDialog();
                this.Close();
            }
            else if(AccountType=="Vet"|| AccountType == "vet")
            {
                //load Vet form
            }
            else if(AccountType=="Manager"|| AccountType == "manager")
            {
                //load manager form
            }
            else if(AccountType=="Admin"|| AccountType == "admin")
            {
                Admin a = new Admin(username.Text);
                this.Hide();
                a.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartForm a = new StartForm();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }
    }
}
