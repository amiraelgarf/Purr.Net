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
    public partial class SignUp : Form
    {
        Controller controllerObj;
        string UsernameC;
        public SignUp()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if(password.Text==""|| lName.Text==""|| fName.Text==""|| DOB.Text==""|| Gender.Text==""|| username.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else if (Gender.Text != "F" && Gender.Text != "M")
            {
                MessageBox.Show("Please, insert gender as F for female and M for Male");
            }
            else
            {
                int r = controllerObj.InsertAuthen(username.Text, password.Text, "Customer");
                if (r == 0)
                {
                    MessageBox.Show("Please, insert a unique username");

                }
                else
                {
                    int userID;
                    int count = controllerObj.UserCount();
                    if (count != 0)
                    {
                        userID = controllerObj.GenerateID();

                    }
                    else
                    {
                        userID = 1;
                    }
                    int u = controllerObj.InsertUser(userID, fName.Text, lName.Text, DOB.Text, Gender.Text);

                    int m = controllerObj.InsertCustromer(userID, username.Text);
                    if (u == 0 || m == 0)
                    {
                        MessageBox.Show("Please, insert values correctly");
                    }
                    else
                    {
                        UsernameC = username.Text;
                        Quiz a = new Quiz(UsernameC);
                        this.Hide();
                        a.ShowDialog();
                        this.Close();

                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartForm a = new StartForm();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }
    }
}
