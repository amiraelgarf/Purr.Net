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
    public partial class Profile : Form
    {
        Controller controllerObj;

        private bool isDragging;
        private Point offset;
        private const int radius = 20;

        DataTable Customer, User, Auth;
        string username;
        int CustomerID;
        string date, pass;
        string FNAME, LNAME;
        public Profile(string user)
        {
            username = user;
            InitializeComponent();
            controllerObj = new Controller();
            CustomerID = controllerObj.GetCustomerID(user);
            Auth = controllerObj.GetAuth(user);
            pass = Auth.Rows[0]["Password"].ToString();
            Customer = controllerObj.SelectCustomer(CustomerID);
            User = controllerObj.SelectUser(CustomerID);
            username_label.Text += username;
            DateTime temp = DateTime.Parse(User.Rows[0]["DateOfBirth"].ToString());
            date_text.Text = temp.ToString("yyyy-MM-dd");
            date = temp.ToString("yyyy-MM-dd");
            age_label.Text += User.Rows[0]["Age"].ToString();
            name_text.Text = User.Rows[0]["FirstName"].ToString() + " " + User.Rows[0]["LastName"].ToString();
            FNAME = User.Rows[0]["FirstName"].ToString();
            LNAME = User.Rows[0]["LastName"].ToString();
            gender_label.Text += User.Rows[0]["Gender"].ToString();
            int nature, mind, identity, energy;
            energy = Convert.ToInt32(Customer.Rows[0]["Energy"]);
            mind = Convert.ToInt32(Customer.Rows[0]["Mind"]);
            nature = Convert.ToInt32(Customer.Rows[0]["Nature"]);
            identity = Convert.ToInt32(Customer.Rows[0]["Identityy"]);
            if (energy >= 50)
            {
                personality_label.Text += "E";
            }
            else
            {
                personality_label.Text += "I";
            }
            if (nature >= 50)
            {
                personality_label.Text += "N";
            }
            else
            {
                personality_label.Text += "S";
            }
            if (mind >= 50)
            {
                personality_label.Text += "T";
            }
            else
            {
                personality_label.Text += "F";
            }
            if (identity >= 50)
            {
                personality_label.Text += "P";
            }
            else
            {
                personality_label.Text += "J";
            }


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

        private void pets_select_MouseLeave(object sender, EventArgs e)
        {
            pets_nav_selected.Visible=false;
            pets_select.Visible=false;
        }

        private void pets_nav_MouseHover(object sender, EventArgs e)
        {
            pets_nav_selected.Visible = true;
            pets_select.Visible = true;
        }

        private void pets_select_Click(object sender, EventArgs e)
        {
            Pets v = new Pets(username);
            this.Hide();
            v.ShowDialog();
            this.Close();
        }

        private void products_select_Click(object sender, EventArgs e)
        {
            Products v = new Products(username);
            this.Hide();
            v.ShowDialog();
            this.Close();
        }

        private void center_icon_Click(object sender, EventArgs e)
        {
            Centers c = new Centers(username);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void appointments_select_Click(object sender, EventArgs e)
        {
            Vets v = new Vets(username);
            this.Hide();
            v.ShowDialog();
            this.Close();
             
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show("ARE YOU SURE??!!!!!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    MessageBox.Show("Your lose");
                    MessageBox.Show("Bye!");
                    int x = controllerObj.DeleteUser(CustomerID);
                    int y = controllerObj.DeleteAuth(username);
                    if(x == 1 )
                    {   if (y == 1)
                        {
                            MessageBox.Show("User was Deleted From Both User and Authentication");
                        }
                        else
                        {
                            MessageBox.Show("User was Deleted From User");
                        }
                    }
                    if (x == 0)
                    {
                        if (y == 1)
                        {
                            MessageBox.Show("User was Deleted From Authentication");
                        }
                        else
                        {
                            MessageBox.Show("User was not Deleted From Neither User or Authentication");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("THANK GOD!!");
                }
            }
            else
            {
                MessageBox.Show("Thank you!");
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            char[] x = name_text.Text.ToCharArray();
            int count = 0;
            int index=0;
            for(int i=0; i<x.Length; i++)
            {
                if (x[i] == ' ' )
                {
                    count++;
                    index = i;
                }
            }
            if (count == 1)
            {
                string Fname = "";
                for(int y=0; y<index; y++)
                {
                    Fname += x[y];
                }
                string Lname = "";
                for (int y = index+1; y < x.Length; y++)
                {
                    Lname += x[y];
                }
                if (FNAME != Fname || LNAME != Lname)
                {
                    int z = controllerObj.UpdateName(CustomerID, Fname, Lname);
                    if (z == 1)
                    {
                        MessageBox.Show("Name Updated Successfully");
                        FNAME = Fname;
                        LNAME = Lname;
                    }
                    else
                    {
                        MessageBox.Show("Name was not Updated");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a Correct Name Format (FirtName Lastname)");
            }

            if(password_text.Text.Length > 0)
            {
                if(password_text.Text == confirmpassword_text.Text)
                {
                    int v =controllerObj.UpdatePassword(username, password_text.Text);
                    if (v == 1)
                    {
                        MessageBox.Show("Password Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Password was not Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Password isn't the Same as Confirm Password");
                }
            }
            if (date_text.Text != date)
            {
                DateTime d;
                if (DateTime.TryParse(date_text.Text, out d))
                {
                    int v = controllerObj.UpdateDateOfBirth(CustomerID, d);
                    if (v == 1)
                    {
                        MessageBox.Show("Date of Birth Updated Successfully");
                        User = controllerObj.SelectUser(CustomerID);
                        age_label.Text ="Age:  "+ User.Rows[0]["Age"].ToString();
                        date = d.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        MessageBox.Show("Date of Birth was not Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a Correct Date Format");
                }
            }
        }
    }
}
