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
    public partial class Pets : Form
    {
        Controller controllerObj;
        int toggle = 0;
        int page = 0;
        List<string> types_filter_selected = new List<string>();
        List<string> gender_filter_selected = new List<string>();
        List<int> age_filter_selected = new List<int>();
        List<int> id_list = new List<int>();

        private bool isDragging;
        private Point offset;
        private const int radius = 20;

        string username;

        public Pets(string user)
        {
            username = user;
            InitializeComponent();
            controllerObj = new Controller();
            types_list.Items.AddRange(controllerObj.TypeNames());
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
            for(int i = 0; i< types_list.Items.Count; i++)
            {
                types_list.SetItemChecked(i, false);
            }
            for (int i = 0; i < gender_list.Items.Count; i++)
            {
                gender_list.SetItemChecked(i, false);
            }
            for (int i = 0; i < age_list.Items.Count; i++)
            {
                age_list.SetItemChecked(i, false);
            }
            types_filter_selected.Clear();
            gender_filter_selected.Clear();
            age_filter_selected.Clear();
            id_list.Clear();
            insert_slots();
            types_list.Visible = false;
            gender_list.Visible = false;
            age_list.Visible = false;
            types_filter.Visible = true;
            age_filter.Visible = true;
            gender_filter.Visible = true;

        }

        private void types_filter_Click(object sender, EventArgs e)
        {
            if (toggle == 0)
            {
                gender_filter.Visible = false;
                age_filter.Visible = false;
                types_list.Visible = true;
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
            age_filter.Location = new System.Drawing.Point(43, 266);
            gender_filter.Location = new System.Drawing.Point(43, 231);
            types_filter.Location = new System.Drawing.Point(43, 196);
            types_list.Visible = false;
            gender_list.Visible = false;
            age_list.Visible = false;
            types_filter.Visible = true;
            gender_filter.Visible = true;
            age_filter.Visible = true;
        }

        private void gender_filter_Click(object sender, EventArgs e)
        {
            if (toggle == 0)
            {
                age_filter.Visible = false;
                gender_list.Visible = true;
                toggle = 1;
            }
            else
            {
                reset_filter();
                toggle = 0;
            }
        }

        private void age_filter_Click(object sender, EventArgs e)
        {
            if (toggle == 0)
            {
                age_list.Visible = true;
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

        private void Pets_Click(object sender, EventArgs e)
        {
            reset_filter();
            search_text.DeselectAll();
        }

        private void filter_Click(object sender, EventArgs e)
        {
            search_text.DeselectAll();
        }

        private void insert_slots()
        {
            id_list.Clear();
            int count = controllerObj.pets_number_filtered(types_filter_selected, gender_filter_selected, age_filter_selected);
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
                names = controllerObj.PetNamesFiltered(types_filter_selected, gender_filter_selected, age_filter_selected);

                int[] t = controllerObj.PetIDsFiltered(types_filter_selected, gender_filter_selected, age_filter_selected);
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
            if(page == 0)
            {
                previous.Visible = false;
            }
            next.Visible = true;
            insert_slots();
        }

        private void age_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            age_filter_selected.Clear();
            int y = 0;
            int f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, f6 = 0, f7 = 0, f8 = 0;
            for (int i = 0; i < age_list.Items.Count; i++)
            {
                
                if (age_list.GetItemChecked(i))
                {
                    /*0-2 Months
                    2-4 Months
                    4-8 Months
                    8-12 Months
                    1-2 Years
                    2-4 Years
                    4-8 Years
                    8-16 Years
                    16+ Years*/
                    if((age_list.Items[i].ToString() == "0-2 Months") && y==0)
                    {
                        age_filter_selected.Add(0);
                        y++;
                    }
                    if (age_list.Items[i].ToString() == "0-2 Months"){
                        age_filter_selected.Add(2);
                        f1 = 1;
                    }
                    if (age_list.Items[i].ToString() == "2-4 Months")
                    {
                        if(f1 == 0)
                        {
                            age_filter_selected.Add(2);
                        }
                        age_filter_selected.Add(4);
                        f2 = 1;
                    }
                    if (age_list.Items[i].ToString() == "4-8 Months")
                    {
                        if (f2 == 0)
                        {
                            age_filter_selected.Add(4);
                        }
                        age_filter_selected.Add(8);
                        f3 = 1;
                    }
                    if (age_list.Items[i].ToString() == "8-12 Months")
                    {
                        if (f3 == 0)
                        {
                            age_filter_selected.Add(8);
                        }
                        age_filter_selected.Add(12);
                        f4 = 1;
                    }
                    if (age_list.Items[i].ToString() == "1-2 Years")
                    {
                        if (f4 == 0)
                        {
                            age_filter_selected.Add(12);
                        }
                        age_filter_selected.Add(24);
                        f5 = 1;
                    }
                    if (age_list.Items[i].ToString() == "2-4 Years")
                    {
                        if (f5 == 0)
                        {
                            age_filter_selected.Add(24);
                        }
                        age_filter_selected.Add(48);
                        f6 = 1;
                    }
                    if (age_list.Items[i].ToString() == "4-8 Years")
                    {
                        if (f6 == 0)
                        {
                            age_filter_selected.Add(48);
                        }
                        age_filter_selected.Add(96);
                        f7 = 1;
                    }
                    if (age_list.Items[i].ToString() == "8-16 Years")
                    {
                        if (f7 == 0)
                        {
                            age_filter_selected.Add(96);
                        }
                        age_filter_selected.Add(96*2);
                        f8 = 1;
                    }
                    if (age_list.Items[i].ToString() == "16+ Years")
                    {
                        age_filter_selected.Add(9999);
                    }


                }
            }
            insert_slots();
        }

        private void gender_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender_filter_selected.Clear();
            for (int i = 0; i < gender_list.Items.Count; i++)
            {
                if (gender_list.GetItemChecked(i))
                {
                    gender_filter_selected.Add(gender_list.Items[i].ToString());
                }
            }
            insert_slots();
        }

        private void types_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            types_filter_selected.Clear();
            for (int i = 0; i < types_list.Items.Count; i++)
            {
                if (types_list.GetItemChecked(i))
                {
                    types_filter_selected.Add(types_list.Items[i].ToString());
                }
            }
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
            ViewPet p = new ViewPet(username, id_list[0 + page * 8]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot2_label_Click(object sender, EventArgs e)
        {
            ViewPet p = new ViewPet(username, id_list[1 + page * 8]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot3_label_Click(object sender, EventArgs e)
        {
            ViewPet p = new ViewPet(username, id_list[2 + page * 8]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot4_label_Click(object sender, EventArgs e)
        {
            ViewPet p = new ViewPet(username, id_list[3 + page * 8]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot5_label_Click(object sender, EventArgs e)
        {
            ViewPet p = new ViewPet(username, id_list[4 + page * 8]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot6_label_Click(object sender, EventArgs e)
        {
            ViewPet p = new ViewPet(username, id_list[5 + page * 8]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot7_label_Click(object sender, EventArgs e)
        {
            ViewPet p = new ViewPet(username, id_list[6 + page * 8]);
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void slot8_label_Click(object sender, EventArgs e)
        {
            ViewPet p = new ViewPet(username, id_list[7 + page * 8]);
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

        private void appointments_select_Click(object sender, EventArgs e)
        {
            Vets v = new Vets(username);
            this.Hide();
            v.ShowDialog();
            this.Close();
        }

        private void profile_select_Click(object sender, EventArgs e)
        {
            Profile v = new Profile(username);
            this.Hide();
            v.ShowDialog();
            this.Close();

        }

        public void FilterPetsByBestFor(string bestFor)
        {
            List<string> bestfor_filter = new List<string>();
            bestfor_filter.Add(bestFor); 

            insert_slots();
        }



    }
}
