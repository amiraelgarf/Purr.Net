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
    public partial class ViewAndEditProductManager : Form
    {
        Controller controllerObj;

        private bool isDragging;
        private Point offset;
        private const int radius = 20;
        DataTable Pet;
        string username;
        int ProductID;
        int stock;
        public ViewAndEditProductManager(string user, int id)
        {
            username = user;
            ProductID = id;
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dtTypes = controllerObj.SelectAllTypes();
            TypeDropDown.DisplayMember = "TypeName";
            TypeDropDown.ValueMember = "TypeID";
            TypeDropDown.DataSource = dtTypes;

            Pet = controllerObj.SelectProduct(ProductID);
            product_name_textbox.Text = Pet.Rows[0]["Name"].ToString();
            int typeid = Convert.ToInt32(Pet.Rows[0]["ForTypeID"]);
            type_label.Text += controllerObj.getType(typeid);
            price_textbox.Text += Convert.ToString(Pet.Rows[0]["Cost"]).ToString();
            stock_textbox.Text += Convert.ToString(Pet.Rows[0]["Stock"]).ToString();
            int centerid = Convert.ToInt32(Pet.Rows[0]["CenterID"]);
            center_textbox.Text += controllerObj.CenterName(centerid);
            description_textbox.Text += Pet.Rows[0]["Description"].ToString();
            stock = Convert.ToInt32(Pet.Rows[0]["Stock"]);
           
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
            ProductsViewManager p = new ProductsViewManager(username);
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

        private void pets_nav_MouseHover(object sender, EventArgs e)
        {
            pets_nav_selected.Visible = true;
            pets_select.Visible = true;
        }

        private void pets_select_Click(object sender, EventArgs e)
        {
            Pets p = new Pets(username);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void pets_select_MouseLeave(object sender, EventArgs e)
        {
            pets_nav_selected.Visible = false;
            pets_select.Visible = false;
        }

 

        private void center_icon_Click(object sender, EventArgs e)
        {
            /*Centers c = new Centers(username);
            this.Hide();
            c.ShowDialog();
            this.Close();*/
        }

        private void Remove_button(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteProduct(ProductID);
            if (r == 0)
            {
                MessageBox.Show("Failed to remove product");
            }
            else
            {
                MessageBox.Show("Removed successfully");
            }
        }
        private void remove_label_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteProduct(ProductID);
            if (r == 0)
            {
                MessageBox.Show("Failed to remove product");
            }
            else
            {
                MessageBox.Show("Removed successfully");
            }
        }

        private void save_label_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(product_name_textbox.Text))
            {
                MessageBox.Show("Incorrect Input, you must enter a name");
                return;
            }

            if (string.IsNullOrEmpty(description_textbox.Text))
            {
                MessageBox.Show("Incorrect Input, you must enter a description");
                return;
            }

            int centerID = controllerObj.GetCenterID(center_textbox.Text);
            if (centerID == -1)
            {
                MessageBox.Show("Center not found, please enter an existing center");
                return;
            }

            if (!decimal.TryParse(price_textbox.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Incorrect Input for price, please enter a valid positive number with 2 decimal places");
                return;
            }

            // Ensure price has exactly two decimal places
            price = Math.Round(price, 2);

            // Validate stock
            if (!int.TryParse(stock_textbox.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Incorrect Input for stock, please enter a valid positive integer");
                return;
            }

            int r1 = controllerObj.UpdateProduct(ProductID, product_name_textbox.Text, description_textbox.Text, stock, price, centerID, Convert.ToInt32(TypeDropDown.SelectedValue));

            if (r1 == 0)
            {
                MessageBox.Show("Failed to update. Please check your input and try again.");
            }
            else
            {
                MessageBox.Show("Updated successfully");
            }
        }
    }
}
