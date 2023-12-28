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

namespace DBapplication
{
    public partial class ViewVet : Form
    {
        Controller controllerObj;

        private bool isDragging;
        private Point offset;
        private const int radius = 20;
        DataTable Vet;
        string username;
        int VetID;
        public ViewVet(string user, int id)
        {
            username = user;
            VetID = id;
            InitializeComponent();
            controllerObj = new Controller();

            Vet = controllerObj.GetVetData(VetID);
            vet_name_label.Text += Vet.Rows[0]["LastName"].ToString();
            fullname_label.Text += Vet.Rows[0]["FirstName"].ToString() + " " + Vet.Rows[0]["LastName"].ToString();
            speciality_label.Text += Vet.Rows[0]["Speciality"].ToString();
            center_label.Text += Vet.Rows[0]["Center"].ToString();
            buildingnum_label.Text += Vet.Rows[0]["BuildingNum"].ToString();
            streetnum_label.Text += Vet.Rows[0]["StreetNum"].ToString();
            city_label.Text += Vet.Rows[0]["City"].ToString();
            schedule_label.Text += Vet.Rows[0]["Schedule"].ToString();
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
            Vets p = new Vets(username);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }


        private void PurrfectMatch_Click(object sender, EventArgs e)
        {
            Customer c = new Customer(username);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void mypet_Click(object sender, EventArgs e)
        {
            MyPetsList p = new MyPetsList(username);
            this.Hide();
            p.ShowDialog();
            this.Close();
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



        private void pets_nav_selected_MouseLeave(object sender, EventArgs e)
        {
            pets_nav_selected.Visible = false;
            pets_select.Visible = false;
        }

        private void pets_nav_MouseHover(object sender, EventArgs e)
        {
            pets_nav_selected.Visible = true;
            pets_select.Visible = true;
        }

        private void pets_nav_selected_Click(object sender, EventArgs e)
        {
            Pets p = new Pets(username);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void appointments_nav_selected_Click(object sender, EventArgs e)
        {
            Vets p = new Vets(username);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void profile_select_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(username);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void products_select_Click(object sender, EventArgs e)
        {
            Pets p = new Pets(username);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }
    }
}
