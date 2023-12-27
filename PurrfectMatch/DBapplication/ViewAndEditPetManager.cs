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

namespace DBapplication
{

    public partial class ViewAndEditPetManager : Form
    {
        int x = 0;
        int v = 0;
        int length;
        Controller controllerObj;

        private bool isDragging;
        private Point offset;
        private const int radius = 20;
        DataTable Pet;
        string username;
        int PetID;

        public ViewAndEditPetManager(string user, int id)
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dtTypes = controllerObj.SelectAllTypes();
            TypeDropDown.DisplayMember = "TypeName";
            TypeDropDown.ValueMember = "TypeID";
            TypeDropDown.DataSource = dtTypes;

            DataTable dtCenters = controllerObj.SelectAllCenters();
            CenterDropDown.DisplayMember = "CenterName";
            CenterDropDown.ValueMember = "CenterID";
            CenterDropDown.DataSource = dtCenters;

            username = user;
            PetID = id;

            controllerObj = new Controller();
            Pet = controllerObj.SelectPet(PetID);
            name_textbox.Text = Pet.Rows[0]["Name"].ToString();
            int typeid = Convert.ToInt32(Pet.Rows[0]["TypeID"]);
            type_label.Text += controllerObj.getType(typeid);
            breed_textbox.Text += Pet.Rows[0]["Breed"].ToString();
            int age = Convert.ToInt32(Pet.Rows[0]["AgeInMonths"]);
            age_textbox.Enabled = true;
            if (age > 12)
            {
                age_textbox.Text += ((age / 12) + " Years");
            }
            else
            {
                age_textbox.Text += (age + " Months");
            }
            length = age_textbox.Text.Length;

            gender_textbox.Text += Pet.Rows[0]["Gender"].ToString();
            int centerid = Convert.ToInt32(Pet.Rows[0]["CenterID"]);
            center_label.Text += controllerObj.CenterName(centerid);
            personality_label.Visible = true;
            bestfor_textbox.Text = Pet.Rows[0]["BestFor"].ToString();
            label_history.Visible = true;
            history_textbox.Text = Pet.Rows[0]["History"].ToString();
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw rounded edges
            using (GraphicsPath path = new GraphicsPath())
            {
                int width = this.Width;
                int height = this.Height;

                path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                path.AddArc(width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
                path.AddArc(width - radius * 2, height - radius * 2, radius * 2, radius * 2, 0, 90);
                path.AddArc(0, height - radius * 2, radius * 2, radius * 2, 90, 90);

                path.CloseFigure();

                this.Region = new Region(path);
            }

            // Optionally, you can draw other custom content here
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

        private void products_select_MouseLeave(object sender, EventArgs e)
        {
            products_nav_selected.Visible = false;
            products_select.Visible = false;
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

        private void goback_button_Click(object sender, EventArgs e)
        {
            PetsViewManager p = new PetsViewManager(username);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }


        private void saveedits_button_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                DateTime dateOfBirth;

                if (!DateTime.TryParse(age_textbox.Text, out dateOfBirth))
                {
                    MessageBox.Show("Incorrect way to update Age, please input the updated date of birth");
                    return;
                }
                else
                {
                    int r1 = controllerObj.UpdateAge(PetID, dateOfBirth);
                    if (r1 == 0)
                    {
                        MessageBox.Show("Failed to update. Please check your input and try again.");
                    }
                    else
                    {
                        MessageBox.Show("Age Updated successfully");
                    }
                }
            }



            int r2 = controllerObj.UpdatePet(PetID, name_textbox.Text, gender_textbox.Text, breed_textbox.Text, Convert.ToInt32(TypeDropDown.SelectedValue), bestfor_textbox.Text, history_textbox.Text, Convert.ToInt32(CenterDropDown.SelectedValue));
            if (r2 == 0)
            {
                MessageBox.Show("Failed to update. Please check your input and try again.");
            }
            else if (string.IsNullOrEmpty(name_textbox.Text))
            {
                MessageBox.Show("Incorrect Input, you must enter a name");
            }
            else if (gender_textbox.Text != "Female" && gender_textbox.Text != "Male")
            {
                MessageBox.Show("Incorrect Input, you must input either 'Female' or 'Male' for gender");
            }
            else
            {
                MessageBox.Show("Updated successfully");
            }
        }

        private void Remove_button(object sender, EventArgs e)
        {
            int r = controllerObj.DeletePet(PetID);
            if (r == 0)
            {
                MessageBox.Show("Failed to remove pet");
            }
            else
            {
                MessageBox.Show("Removed successfully");
            }
        }
        private void remove_label_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeletePet(PetID);
            if (r == 0)
            {
                MessageBox.Show("Failed to remove pet");
            }
            else
            {
                MessageBox.Show("Removed successfully");
            }
        }



        private void age_textbox_TextChanged(object sender, EventArgs e)
        {

            if (v != 0)
            {
                int y;
                y = age_textbox.Text.Length;
                if (y == length)
                {
                    x = 0;
                }
                else
                {
                    x = 1;
                }
            }
            v++;
        }

    }

}

