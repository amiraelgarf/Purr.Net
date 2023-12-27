using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{

    public partial class AddPetManager : Form
    {
        private bool isDragging;
        private Point offset;
        Controller controllerObj;

        public AddPetManager(string user)
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void add_label_Click(object sender, EventArgs e)
        {
            DateTime dateOfBirth;
            if (name_textbox.Text == "" || gender_textbox.Text == "" || breed_textbox.Text == "" || type_textbox.Text == "" || age_textbox.Text == "" || bestfor_textbox.Text == "" || history_textbox.Text == "" || center_textbox.Text == "")
            {
                MessageBox.Show("Please, insert all values");
                return;
            }

            if (gender_textbox.Text != "Female" && gender_textbox.Text != "Male")
            {
                MessageBox.Show("Incorrect Input, you must input either 'Female' or 'Male' for gender");
                return;
            }

            int typeID = controllerObj.GetTypeID(type_textbox.Text);
            if (typeID == -1)
            {
                int r1 = controllerObj.InsertType(type_textbox.Text);
                if (r1 == 0)
                {
                    MessageBox.Show("Failed to insert Type");
                    return;
                }
            }

            if (!DateTime.TryParse(age_textbox.Text, out dateOfBirth))
            {
                MessageBox.Show("Incorrect way to update Age, please input the date of birth");
                return;
            }

            int centerID = controllerObj.GetCenterID(center_textbox.Text);
            if (centerID == -1)
            {
                MessageBox.Show("Center not found, please enter an existing center");
                return;
            }

            int r = controllerObj.InsertPet(name_textbox.Text, gender_textbox.Text, breed_textbox.Text, type_textbox.Text, dateOfBirth, bestfor_textbox.Text, history_textbox.Text, center_textbox.Text);
            if (r == 0)
            {
                MessageBox.Show("Please, insert values correctly");
            }
            else
            {
                MessageBox.Show("Pet Added successfully");
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            DateTime dateOfBirth;
            if (name_textbox.Text == "" || gender_textbox.Text == "" || breed_textbox.Text == "" || type_textbox.Text == "" || age_textbox.Text == "" || bestfor_textbox.Text == "" || history_textbox.Text == "" || center_textbox.Text == "")
            {
                MessageBox.Show("Please, insert all values");
                return;
            }

            if (gender_textbox.Text != "Female" && gender_textbox.Text != "Male")
            {
                MessageBox.Show("Incorrect Input, you must input either 'Female' or 'Male' for gender");
                return;
            }

            int typeID = controllerObj.GetTypeID(type_textbox.Text);
            if (typeID == -1)
            {
                int r1 = controllerObj.InsertType(type_textbox.Text);
                if (r1 == 0)
                {
                    MessageBox.Show("Failed to insert Type");
                    return;
                }
            }

            if (!DateTime.TryParse(age_textbox.Text, out dateOfBirth))
            {
                MessageBox.Show("Incorrect way to update Age, please input the date of birth");
                return;
            }

            int centerID = controllerObj.GetCenterID(center_textbox.Text);
            if (centerID == -1)
            {
                MessageBox.Show("Center not found, please enter an existing center");
                return;
            }

            int r = controllerObj.InsertPet(name_textbox.Text, gender_textbox.Text, breed_textbox.Text, type_textbox.Text, dateOfBirth, bestfor_textbox.Text, history_textbox.Text, center_textbox.Text);
            if (r == 0)
            {
                MessageBox.Show("Please, insert values correctly");
            }
            else
            {
                MessageBox.Show("Pet Added successfully");
            }
        }


        private void DraggableForm_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = new Point(e.X, e.Y);
        }

        private void DraggableForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(newLocation.X - offset.X, newLocation.Y - offset.Y);
            }
        }

        private void DraggableForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void products_nav_MouseHover(object sender, EventArgs e)
        {
            products_nav_selected.Visible = true;
            products_select.Visible = true;
        }

        private void appointments_select_MouseLeave(object sender, EventArgs e)
        {
            appointments_nav_selected.Visible = false;
            appointments_select.Visible = false;
        }

        private void appointments_nav_MouseHover(object sender, EventArgs e)
        {
            appointments_nav_selected.Visible = true;
            appointments_select.Visible = true;
        }

        private void profile_nav_MouseHover(object sender, EventArgs e)
        {
            profile_nav_selected.Visible = true;
            profile_select.Visible = true;
        }

        private void profile_nav_selected_MouseLeave(object sender, EventArgs e)
        {
            profile_nav_selected.Visible = false;
            profile_select.Visible = false;
        }



        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


