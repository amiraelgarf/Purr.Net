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
    public partial class RegisterRemoveVet : Form
    {
        Controller controllerObj;
        string Username;
        public RegisterRemoveVet(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Username = username;

            DataTable dt1 = controllerObj.SelectAllCenters();
            comboBox1.DisplayMember = "CenterName";
            comboBox1.ValueMember = "CenterID";
            comboBox1.DataSource = dt1;


            DataTable dt2 = controllerObj.SelectAllVets();
            comboBox2.DisplayMember = "FirstName";
            comboBox2.ValueMember = "UserID";
            comboBox2.DataSource = dt2;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (fName.Text == "" || lName.Text == "" || DOB.Text == "" || Gender.Text == "" || Speciality.Text == "" || Schedule.Text == "" || username.Text == "" || password.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                
                
                {
                    int r = controllerObj.InsertAuthen(username.Text, password.Text, "Vet");
                    int userID = controllerObj.GenerateID();
                    int u = controllerObj.InsertUser(userID, fName.Text, lName.Text, DOB.Text, Gender.Text);

                    int m = controllerObj.InsertVet(userID, Convert.ToInt32(comboBox1.SelectedValue), Speciality.Text, Schedule.Text , username.Text);
                    if (r == 0 || u == 0 || m == 0)
                    {
                        MessageBox.Show("Please, insert values correctly");
                    }
                    else
                    {
                        MessageBox.Show("Vet inserted successfully");
                    }
                }
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string VetUsername = controllerObj.GetVetUsername(Convert.ToInt32(comboBox2.SelectedValue));
            int r = controllerObj.DeleteVet(Convert.ToInt32(comboBox2.SelectedValue), VetUsername);
            if (r == 0)
            {
                MessageBox.Show("failed to delete");
            }
            else
            {
                MessageBox.Show("deleted successfully");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.GetAverageAppointmentsPerMonth();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin a = new Admin(Username);
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
