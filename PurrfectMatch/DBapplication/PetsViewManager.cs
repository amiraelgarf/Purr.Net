using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DBapplication
{
    public partial class PetsViewManager : Form
    {
        Controller controllerObj;
        int toggle = 0;
        int page = 0;
        List<int> id_list = new List<int>();

        private bool isDragging;
        private Point offset;
        private const int radius = 20;

        string username;
        public PetsViewManager(string user)
        {
            username = user;
            InitializeComponent();
            controllerObj = new Controller();
            insert_slots();
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

        private void Pets_Click(object sender, EventArgs e)
        {
            search_text.DeselectAll();
        }

        private void filter_Click(object sender, EventArgs e)
        {
            search_text.DeselectAll();
        }

        private void insert_slots()
        {
            id_list.Clear();
            int count = controllerObj.PetNumber();
            PictureBox[] slots = { slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8 };
            Label[] slot_labels = { slot1_label, slot2_label, slot3_label, slot4_label, slot5_label, slot6_label, slot7_label, slot8_label };
            if (count == 0)
            {
                int x = 0;
                while (x < 8)
                {
                    slots[x].Visible = false;
                    slot_labels[x].Visible = false;
                    x++;
                }
            }
            if (count > 0)
            {

                int n = count - (8 * page);
                next.Visible = false;
                if ((count - 8 * page) > 8)
                {
                    next.Visible = true;
                    n = 8 + (8 * page);
                }
                string[] names = new string[count];
                names = controllerObj.PetNames();

                int[] t = controllerObj.PetIDs();
                for (int i = 0; i < t.Length; i++)
                {
                    id_list.Add(t[i]);
                }

                int x = 0;
                while (x < 8)
                {
                    slots[x].Visible = false;
                    slot_labels[x].Visible = false;
                    x++;
                }
                int y = 0;
                if (n > 8)
                {
                    n = 8;
                }
                for (int i = 0; i < n; i++)
                {
                    slot_labels[y].Text = names[i + (8 * page)];
                    slot_labels[y].Visible = true;
                    slots[y].Image = global::DBapplication.Properties.Resources.Nola;
                    slots[y].Visible = true;
                    y++;
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            page++;
            previous.Visible = true;
            insert_slots();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            page--;
            if (page == 0)
            {
                previous.Visible = false;
            }
            next.Visible = true;
            insert_slots();
        }



        private void search_text_TextChanged(object sender, EventArgs e)
        {
            id_list.Clear();
            string name = search_text.Text;
            int count = controllerObj.PetNumberSearch(name);
            PictureBox[] slots = { slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8 };
            Label[] slot_labels = { slot1_label, slot2_label, slot3_label, slot4_label, slot5_label, slot6_label, slot7_label, slot8_label };
            if (count == 0)
            {
                int x = 0;
                while (x < 8)
                {
                    slots[x].Visible = false;
                    slot_labels[x].Visible = false;
                    x++;
                }
            }
            if (count > 0)
            {

                int n = count - (8 * page);
                next.Visible = false;
                if ((count - 8 * page) > 8)
                {
                    next.Visible = true;
                    n = 8 + (8 * page);
                }
                string[] names = new string[count];
                names = controllerObj.PetNameSearch(name);

                int[] t = controllerObj.PetIDsSearch(name);
                for (int i = 0; i < t.Length; i++)
                {
                    id_list.Add(t[i]);
                }

                int x = 0;
                while (x < 8)
                {
                    slots[x].Visible = false;
                    slot_labels[x].Visible = false;
                    x++;
                }
                int y = 0;
                if (n > 8)
                {
                    n = 8;
                }
                for (int i = 0; i < n; i++)
                {
                    slot_labels[y].Text = names[i + (8 * page)];
                    slot_labels[y].Visible = true;
                    slots[y].Image = global::DBapplication.Properties.Resources.Nola;
                    slots[y].Visible = true;
                    y++;
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void slot1_label_Click(object sender, EventArgs e)
        {
            ViewAndEditPetManager p = new ViewAndEditPetManager(username, id_list[0 + (8 * page)]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot2_label_Click(object sender, EventArgs e)
        {
            ViewAndEditPetManager p = new ViewAndEditPetManager(username, id_list[1 + (8 * page)]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot3_label_Click(object sender, EventArgs e)
        {
            ViewAndEditPetManager p = new ViewAndEditPetManager(username, id_list[2 + (8 * page)]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot4_label_Click(object sender, EventArgs e)
        {
            ViewAndEditPetManager p = new ViewAndEditPetManager(username, id_list[3 + (8 * page)]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot5_label_Click(object sender, EventArgs e)
        {
            ViewAndEditPetManager p = new ViewAndEditPetManager(username, id_list[4 + (8 * page)]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot6_label_Click(object sender, EventArgs e)
        {
            ViewAndEditPetManager p = new ViewAndEditPetManager(username, id_list[5 + (8 * page)]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot7_label_Click(object sender, EventArgs e)
        {
            ViewAndEditPetManager p = new ViewAndEditPetManager(username, id_list[6 + (8 * page)]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot8_label_Click(object sender, EventArgs e)
        {
            ViewAndEditPetManager p = new ViewAndEditPetManager(username, id_list[7 + (8 * page)]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void search_text_Click(object sender, EventArgs e)
        {
            search_text.SelectAll();
        }



        private void add_button_Click(object sender, EventArgs e)
        {
            AddPetManager ap = new AddPetManager(username);
            ap.Show();
        }

        private void add_label_Click(object sender, EventArgs e)
        {
            AddPetManager ap = new AddPetManager(username);
            ap.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdoptionRequests A= new AdoptionRequests(username);
            A.Show();
        }
    }
}
