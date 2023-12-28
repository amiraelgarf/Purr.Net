using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBapplication
{
    public partial class MyPet : Form
    {
        Controller controllerObj;
        private bool isDroppedUp = false;

        private bool isDragging;
        private Point offset;
        private const int radius = 20;
        DataTable Pet, centers;
        string username;
        int PetID;
        string petname;
        public MyPet(string user, int id)
        {
            username = user;
            PetID = id;
            InitializeComponent();
            controllerObj = new Controller();

            centers = controllerObj.SelectAllCenters();
            centers_list.ValueMember = "CenterID";
            centers_list.DisplayMember = "CenterName";
            centers_list.DataSource = centers;

            Pet = controllerObj.SelectPet(PetID);
            name_text.Text = Pet.Rows[0]["Name"].ToString();
            petname=name_text.Text;
            int typeid = Convert.ToInt32(Pet.Rows[0]["TypeID"]);
            type_label.Text += controllerObj.getType(typeid);
            breed_label.Text += Pet.Rows[0]["Breed"].ToString();
            int age = Convert.ToInt32(Pet.Rows[0]["AgeInMonths"]);
            if (age > 12)
            {
                age_label.Text += ((age / 12) + " Years");
            }
            else
            {
                age_label.Text += (age  + " Months");
            }
            gender_label.Text += Pet.Rows[0]["Gender"].ToString();
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




        private void mypet_MouseHover(object sender, EventArgs e)
        {
            mypet.BorderStyle = BorderStyle.FixedSingle;
        }

        private void mypet_MouseLeave(object sender, EventArgs e)
        {
            mypet.BorderStyle = BorderStyle.None;
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

        private void quiz_select_MouseLeave(object sender, EventArgs e)
        {
            quiz_nav_selected.Visible = false;
            quiz_select.Visible = false;
        }

        private void quiz_nav_MouseHover(object sender, EventArgs e)
        {
            quiz_nav_selected.Visible = true;
            quiz_select.Visible = true;
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
            if (petname == name_text.Text)
            {
                MyPetsList p = new MyPetsList(username);
                this.Hide();
                p.ShowDialog();
                this.Close();
            }
            else
            {
                int x = controllerObj.UpdatePetName(PetID, name_text.Text);
                if (x == 1)
                {
                    MessageBox.Show("Pet Name Updated Successfully");
                    MyPetsList p = new MyPetsList(username);
                    this.Hide();
                    p.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pet Name was not Updated");
                }
            }
        }

        private void disown_button_Click(object sender, EventArgs e)
        {
            int z = controllerObj.RemoveOwnership(PetID);
            int y = controllerObj.UpdatePetCenter(PetID, Convert.ToInt32(centers_list.SelectedValue));

            if (petname == name_text.Text)
            {
                if (z == 1)
                {
                    MessageBox.Show("Pet Disowned Successfully ");
                    MyPetsList p = new MyPetsList(username);
                    this.Hide();
                    p.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pet was not Disowned");
                }
            }
            else
            {
                int x = controllerObj.UpdatePetName(PetID, petname);
                if (x == 1)
                {
                    MessageBox.Show("Pet Name Updated Successfully");
                    if (z == 1)
                    {
                        MessageBox.Show("Pet Disowned Successfully ");
                        MyPetsList p = new MyPetsList(username);
                        this.Hide();
                        p.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Pet was not Disowned");
                    }
                }
                else
                {
                    MessageBox.Show("Pet Name was not Updated");
                }
            }

            
            
        }

        private void pets_select_MouseLeave(object sender, EventArgs e)
        {
            pets_nav_selected.Visible = false;
            pets_select.Visible = false;
        }

        private void products_select_Click(object sender, EventArgs e)
        {
            Products c = new Products(username);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void pets_nav_selected_Click(object sender, EventArgs e)
        {
            Pets c = new Pets(username);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void pets_nav_MouseHover(object sender, EventArgs e)
        {
            pets_nav_selected.Visible = true;
            pets_select.Visible = true;
        }

        private void center_icon_MouseHover(object sender, EventArgs e)
        {
            center_icon.BorderStyle = BorderStyle.FixedSingle;
        }

        private void center_icon_MouseLeave(object sender, EventArgs e)
        {
            center_icon.BorderStyle = BorderStyle.None;
        }

        private void center_icon_Click(object sender, EventArgs e)
        {
            Centers c = new Centers(username);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void appointments_nav_selected_Click(object sender, EventArgs e)
        {
            Vets v = new Vets(username);
            this.Hide();
            v.ShowDialog();
            this.Close();
        }

        private void profile_nav_selected_Click(object sender, EventArgs e)
        {
            Profile c = new Profile(username);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void PurrfectMatch_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(username);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
    }
}
