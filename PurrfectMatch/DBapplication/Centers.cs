﻿using System;
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
    public partial class Centers : Form
    {
        Controller controllerObj;
        int toggle = 0;
        int page = 0;
        List<string> city_filter_selected = new List<string>();
        List<int> id_list = new List<int>();

        private bool isDragging;
        private Point offset;
        private const int radius = 20;

        string username;

        public Centers(string user)
        {
            username = user;
            InitializeComponent();
            controllerObj = new Controller();
            city_list.Items.AddRange(controllerObj.CityNames());
            reset_filter();
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


        private void search_text_Click(object sender, EventArgs e)
        {
            search_text.SelectAll();
            for(int i = 0; i< city_list.Items.Count; i++)
            {
                city_list.SetItemChecked(i, false);
            }
            city_filter_selected.Clear();
            id_list.Clear();
            insert_slots();
            city_list.Visible = false;
            city_filter.Visible = true;

        }

        private void city_filter_Click(object sender, EventArgs e)
        {
            if (toggle == 0)
            {
                city_list.Visible = true;
                toggle = 1;
            }
            else
            {
                reset_filter();
                toggle = 0;
            }

        }

        private void reset_filter()
        {
            city_filter.Location = new System.Drawing.Point(43, 196);
            city_list.Visible = false;
            city_filter.Visible = true;
        }



        private void rating_filter_Click(object sender, EventArgs e)
        {
            if (toggle == 0)
            {
                toggle = 1;
            }
            else
            {
                reset_filter();
                toggle = 0;
            }
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

        private void filter_Click(object sender, EventArgs e)
        {
            search_text.DeselectAll();
        }

        private void insert_slots()
        {
            id_list.Clear();
            int count = controllerObj.CenterNumberFiltered(city_filter_selected);
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
                int[] t = controllerObj.CenterIDsFiltered(city_filter_selected);

                for(int i=0; i<count; i++)
                {
                    names[i] = controllerObj.CenterName(t[i]);
                }

                for(int i=0; i<t.Length; i++)
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
                if(n>8)
                {
                    n = 8;
                }
                for (int i = 0; i < n; i++)
                {
                    slot_labels[y].Text = names[i + (8 * page)];
                    slot_labels[y].Visible = true;
                    slots[y].Image = global::DBapplication.Properties.Resources.Dr;
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
            if(page == 0)
            {
                previous.Visible = false;
            }
            next.Visible = true;
            insert_slots();
        }



        private void types_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            city_filter_selected.Clear();
            for (int i = 0; i < city_list.Items.Count; i++)
            {
                if (city_list.GetItemChecked(i))
                {
                    city_filter_selected.Add(city_list.Items[i].ToString());
                }
            }
            insert_slots();
        }

        private void search_text_TextChanged(object sender, EventArgs e)
        {
            id_list.Clear();
            string name = search_text.Text;
            int count = controllerObj.CenterNumberSearch(name);
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
                int[] t = controllerObj.CenterIDsSearch(name);

                for (int i = 0; i < count; i++)
                {
                    names[i] = controllerObj.CenterName(t[i]);
                }

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
                    slot_labels[y].Text =names[i + (8 * page)];
                    slot_labels[y].Visible = true;
                    slots[y].Image = global::DBapplication.Properties.Resources.Dr;
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
            ViewCenter p = new ViewCenter(username, id_list[0] + page * 8);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot2_label_Click(object sender, EventArgs e)
        {
            ViewCenter p = new ViewCenter(username, id_list[1]+page*8);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot3_label_Click(object sender, EventArgs e)
        {
            ViewCenter p = new ViewCenter(username, id_list[2] + page * 8);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot4_label_Click(object sender, EventArgs e)
        {
            ViewCenter p = new ViewCenter(username, id_list[3] + page * 8);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot5_label_Click(object sender, EventArgs e)
        {
            ViewCenter p = new ViewCenter(username, id_list[4] + page * 8);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot6_label_Click(object sender, EventArgs e)
        {
            ViewVet p = new ViewVet(username, id_list[5] + page * 8);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot7_label_Click(object sender, EventArgs e)
        {
            ViewVet p = new ViewVet(username, id_list[6] + page * 8);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot8_label_Click(object sender, EventArgs e)
        {
            ViewVet p = new ViewVet(username, id_list[7] + page * 8);
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

        private void products_select_Click(object sender, EventArgs e)
        {
            Products p = new Products(username);
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

        private void appointments_select_MouseLeave_1(object sender, EventArgs e)
        {
            appointments_nav_selected.Visible = false;
            appointments_select.Visible = false;
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
    }
}
