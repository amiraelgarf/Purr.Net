using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace DBapplication
{


    public partial class Vet : Form
    {
        DataTable vet;
        int vetID;
        Controller controllerObj;
        string UserName;
        public Vet(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            UserName = username;
            vetID = controllerObj.GetVetID(username);
            DataTable dt1 = controllerObj.SelectAvailableDates(vetID);
            comboBox1.DisplayMember = "Datee";
            comboBox1.ValueMember = "Datee";
            comboBox1.DataSource = dt1;

        }

        private void editdaysandtime_Click(object sender, EventArgs e)
        {
            
            int r = controllerObj.DeleteAvailableDate(vetID, Convert.ToString(comboBox1.SelectedValue));
            if (r == 0)
            {
                MessageBox.Show("failed to delete");
            }
            else
            {
                MessageBox.Show("deleted successfully");
            }
            comboBox1.DataSource = controllerObj.SelectAvailableDates(vetID);
        }

        private void viewappsched_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectSchedule(vetID);
            ViewApp_ViewRatings.DataSource = dt;
            ViewApp_ViewRatings.Refresh();
        }

        private void viewratings_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.AvgRatings(vetID);
            ViewApp_ViewRatings.DataSource = dt;
            ViewApp_ViewRatings.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )//validation part
            {
                MessageBox.Show("Please, insert a date");
            }
            else
            {
                {
                    int r = controllerObj.InsertAvailableDate(vetID, textBox1.Text);
                  
                    if (r == 0)
                    {
                        MessageBox.Show("Please insert values correctly (year-month-day)");
                    }
                    else
                    {
                        MessageBox.Show("Available date updated successfully");
                    }
                }


            }
            comboBox1.DataSource = controllerObj.SelectAvailableDates(vetID);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewApp_ViewRatings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartForm a = new StartForm();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePassowrd C = new ChangePassowrd(UserName);
            C.ShowDialog();
        }
    }
}
