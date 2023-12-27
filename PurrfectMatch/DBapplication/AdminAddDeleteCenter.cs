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
    public partial class AdminAddDeleteCenter : Form
    {
        Controller controllerObj;
        string Username;
        public AdminAddDeleteCenter(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Username = username;
            
            DataTable dt1 = controllerObj.SelectAllCenters();
            comboBox1.DisplayMember = "CenterName";
            comboBox1.ValueMember = "CenterID";
            comboBox1.DataSource = dt1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                string building = textBox2.Text;
                bool buildingisINT = int.TryParse(building, out _);

                string street = textBox3.Text;
                bool streetisINT = int.TryParse(building, out _);
                if (buildingisINT && streetisINT)
                {
                    int r = controllerObj.InsertCenter(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, textBox5.Text);
                    if (r == 0)
                    {
                        MessageBox.Show("Please, insert values correctly");
                    }
                    else
                    {
                        MessageBox.Show("Center inserted successfully");
                    }
                    
                   
                }
                else
                {
                    MessageBox.Show("Please, insert Building number and street number as an integer");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int r = controllerObj.DeleteCenter(Convert.ToInt32(comboBox1.SelectedValue));
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
