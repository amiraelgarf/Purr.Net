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
    public partial class RegisterRemoveManager : Form
    {

        Controller controllerObj;
        string Username;
        public RegisterRemoveManager(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Username = username;

            DataTable dt1 = controllerObj.SelectAllCenters();
            comboBox1.DisplayMember = "CenterName";
            comboBox1.ValueMember = "CenterID";
            comboBox1.DataSource = dt1;


            DataTable dt2 = controllerObj.SelectAllManager();
            comboBox2.DisplayMember = "FirstName";
            comboBox2.ValueMember = "UserID";
            comboBox2.DataSource = dt2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (fName.Text == "" || lName.Text == "" || DOF.Text == ""  || Gender.Text == "" || username.Text == "" || password.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else if (Gender.Text != "F" && Gender.Text != "M")
            {
                MessageBox.Show("Please, insert gender as F for female and M for Male");
            }
            else
            {

                
                {
                    //int r = controllerObj.InsertCenter(fName.Text, Convert.ToInt32(lName.Text), Convert.ToInt32(DOF.Text), Age.Text, Gender.Text);
                    
                    int r=controllerObj.InsertAuthen(username.Text, password.Text, "Manager");
                    if (r == 0)
                    {
                        MessageBox.Show("Please, insert a unique username");

                    }
                    else
                    {
                        int userID = controllerObj.GenerateID();
                        int u = controllerObj.InsertUser(userID, fName.Text, lName.Text, DOF.Text, Gender.Text);

                        int m = controllerObj.InsertManager(userID, Convert.ToInt32(comboBox1.SelectedValue), username.Text);
                        if (u == 0 || m == 0)
                        {
                            MessageBox.Show("Please, insert values correctly");
                        }
                        else
                        {
                            MessageBox.Show("Manager inserted successfully");
                        }
                    }
                    


                }
                
            }
        }

        private void removeManager_Click(object sender, EventArgs e)
        {
            string managerUsername = controllerObj.GetManagerUsername(Convert.ToInt32(comboBox2.SelectedValue));
            int r = controllerObj.DeleteManager(Convert.ToInt32(comboBox2.SelectedValue), managerUsername );
            if (r == 0)
            {
                MessageBox.Show("failed to delete");
            }
            else
            {
                MessageBox.Show("deleted successfully");
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin(Username);
            this.Hide();
            a.ShowDialog();
            this.Close();

        }
    }
}
