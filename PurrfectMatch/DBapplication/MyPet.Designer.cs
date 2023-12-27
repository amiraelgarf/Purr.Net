using System.Windows.Forms;

namespace DBapplication
{
    partial class MyPet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PurrfectMatch = new System.Windows.Forms.Label();
            this.pets_nav = new System.Windows.Forms.Label();
            this.products_nav = new System.Windows.Forms.Label();
            this.quiz_nav = new System.Windows.Forms.Label();
            this.appointments_nav = new System.Windows.Forms.Label();
            this.profile_nav = new System.Windows.Forms.Label();
            this.pets_nav_selected = new System.Windows.Forms.Label();
            this.appointments_nav_selected = new System.Windows.Forms.Label();
            this.products_nav_selected = new System.Windows.Forms.Label();
            this.profile_nav_selected = new System.Windows.Forms.Label();
            this.quiz_nav_selected = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.appointments_select = new System.Windows.Forms.PictureBox();
            this.products_select = new System.Windows.Forms.PictureBox();
            this.quiz_select = new System.Windows.Forms.PictureBox();
            this.profile_select = new System.Windows.Forms.PictureBox();
            this.pets_select = new System.Windows.Forms.PictureBox();
            this.NavBar = new System.Windows.Forms.PictureBox();
            this.hamtamro = new System.Windows.Forms.PictureBox();
            this.pet_image = new System.Windows.Forms.PictureBox();
            this.type_label = new System.Windows.Forms.Label();
            this.breed_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.gender_label = new System.Windows.Forms.Label();
            this.goback_button = new System.Windows.Forms.PictureBox();
            this.goback_label = new System.Windows.Forms.Label();
            this.disown_button = new System.Windows.Forms.PictureBox();
            this.disown_label = new System.Windows.Forms.Label();
            this.centers_list = new System.Windows.Forms.ComboBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.center_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pets_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamtamro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goback_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disown_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // PurrfectMatch
            // 
            this.PurrfectMatch.AutoSize = true;
            this.PurrfectMatch.BackColor = System.Drawing.Color.Transparent;
            this.PurrfectMatch.Font = new System.Drawing.Font("Abhaya Libre ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.PurrfectMatch.Location = new System.Drawing.Point(43, 20);
            this.PurrfectMatch.Name = "PurrfectMatch";
            this.PurrfectMatch.Size = new System.Drawing.Size(189, 25);
            this.PurrfectMatch.TabIndex = 0;
            this.PurrfectMatch.Text = "PurrfectMatch.com";
            this.PurrfectMatch.Click += new System.EventHandler(this.PurrfectMatch_Click);
            // 
            // pets_nav
            // 
            this.pets_nav.AutoSize = true;
            this.pets_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.pets_nav.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pets_nav.Location = new System.Drawing.Point(89, 69);
            this.pets_nav.Name = "pets_nav";
            this.pets_nav.Size = new System.Drawing.Size(49, 25);
            this.pets_nav.TabIndex = 5;
            this.pets_nav.Text = "Pets";
            this.pets_nav.MouseHover += new System.EventHandler(this.pets_nav_MouseHover);
            // 
            // products_nav
            // 
            this.products_nav.AutoSize = true;
            this.products_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.products_nav.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_nav.Location = new System.Drawing.Point(191, 69);
            this.products_nav.Name = "products_nav";
            this.products_nav.Size = new System.Drawing.Size(90, 25);
            this.products_nav.TabIndex = 6;
            this.products_nav.Text = "Products";
            this.products_nav.MouseHover += new System.EventHandler(this.products_nav_MouseHover);
            // 
            // quiz_nav
            // 
            this.quiz_nav.AutoSize = true;
            this.quiz_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.quiz_nav.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz_nav.Location = new System.Drawing.Point(524, 69);
            this.quiz_nav.Name = "quiz_nav";
            this.quiz_nav.Size = new System.Drawing.Size(54, 25);
            this.quiz_nav.TabIndex = 7;
            this.quiz_nav.Text = "Quiz";
            this.quiz_nav.MouseHover += new System.EventHandler(this.quiz_nav_MouseHover);
            // 
            // appointments_nav
            // 
            this.appointments_nav.AutoSize = true;
            this.appointments_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.appointments_nav.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointments_nav.Location = new System.Drawing.Point(334, 69);
            this.appointments_nav.Name = "appointments_nav";
            this.appointments_nav.Size = new System.Drawing.Size(137, 25);
            this.appointments_nav.TabIndex = 8;
            this.appointments_nav.Text = "Appointments";
            this.appointments_nav.MouseHover += new System.EventHandler(this.appointments_nav_MouseHover);
            // 
            // profile_nav
            // 
            this.profile_nav.AutoSize = true;
            this.profile_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.profile_nav.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_nav.Location = new System.Drawing.Point(631, 69);
            this.profile_nav.Name = "profile_nav";
            this.profile_nav.Size = new System.Drawing.Size(72, 25);
            this.profile_nav.TabIndex = 9;
            this.profile_nav.Text = "Profile";
            this.profile_nav.MouseHover += new System.EventHandler(this.profile_nav_MouseHover);
            // 
            // pets_nav_selected
            // 
            this.pets_nav_selected.AutoSize = true;
            this.pets_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.pets_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pets_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.pets_nav_selected.Location = new System.Drawing.Point(89, 69);
            this.pets_nav_selected.Name = "pets_nav_selected";
            this.pets_nav_selected.Size = new System.Drawing.Size(49, 25);
            this.pets_nav_selected.TabIndex = 15;
            this.pets_nav_selected.Text = "Pets";
            this.pets_nav_selected.Visible = false;
            this.pets_nav_selected.Click += new System.EventHandler(this.pets_nav_selected_Click);
            this.pets_nav_selected.MouseLeave += new System.EventHandler(this.pets_select_MouseLeave);
            // 
            // appointments_nav_selected
            // 
            this.appointments_nav_selected.AutoSize = true;
            this.appointments_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.appointments_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointments_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.appointments_nav_selected.Location = new System.Drawing.Point(334, 69);
            this.appointments_nav_selected.Name = "appointments_nav_selected";
            this.appointments_nav_selected.Size = new System.Drawing.Size(137, 25);
            this.appointments_nav_selected.TabIndex = 38;
            this.appointments_nav_selected.Text = "Appointments";
            this.appointments_nav_selected.Visible = false;
            this.appointments_nav_selected.MouseLeave += new System.EventHandler(this.appointments_select_MouseLeave);
            // 
            // products_nav_selected
            // 
            this.products_nav_selected.AutoSize = true;
            this.products_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.products_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.products_nav_selected.Location = new System.Drawing.Point(191, 69);
            this.products_nav_selected.Name = "products_nav_selected";
            this.products_nav_selected.Size = new System.Drawing.Size(90, 25);
            this.products_nav_selected.TabIndex = 36;
            this.products_nav_selected.Text = "Products";
            this.products_nav_selected.Visible = false;
            this.products_nav_selected.Click += new System.EventHandler(this.products_select_Click);
            this.products_nav_selected.MouseLeave += new System.EventHandler(this.products_select_MouseLeave);
            // 
            // profile_nav_selected
            // 
            this.profile_nav_selected.AutoSize = true;
            this.profile_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.profile_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.profile_nav_selected.Location = new System.Drawing.Point(631, 69);
            this.profile_nav_selected.Name = "profile_nav_selected";
            this.profile_nav_selected.Size = new System.Drawing.Size(72, 25);
            this.profile_nav_selected.TabIndex = 39;
            this.profile_nav_selected.Text = "Profile";
            this.profile_nav_selected.Visible = false;
            this.profile_nav_selected.MouseLeave += new System.EventHandler(this.profile_nav_selected_MouseLeave);
            // 
            // quiz_nav_selected
            // 
            this.quiz_nav_selected.AutoSize = true;
            this.quiz_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.quiz_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quiz_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.quiz_nav_selected.Location = new System.Drawing.Point(524, 69);
            this.quiz_nav_selected.Name = "quiz_nav_selected";
            this.quiz_nav_selected.Size = new System.Drawing.Size(54, 25);
            this.quiz_nav_selected.TabIndex = 37;
            this.quiz_nav_selected.Text = "Quiz";
            this.quiz_nav_selected.Visible = false;
            this.quiz_nav_selected.MouseLeave += new System.EventHandler(this.quiz_select_MouseLeave);
            // 
            // background
            // 
            this.background.Image = global::DBapplication.Properties.Resources.back_2;
            this.background.Location = new System.Drawing.Point(48, 127);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(906, 385);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 59;
            this.background.TabStop = false;
            // 
            // close
            // 
            this.close.Image = global::DBapplication.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(954, 24);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 22);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 58;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // appointments_select
            // 
            this.appointments_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.appointments_select.Image = global::DBapplication.Properties.Resources.Select;
            this.appointments_select.Location = new System.Drawing.Point(325, 66);
            this.appointments_select.Name = "appointments_select";
            this.appointments_select.Size = new System.Drawing.Size(155, 30);
            this.appointments_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appointments_select.TabIndex = 33;
            this.appointments_select.TabStop = false;
            this.appointments_select.Visible = false;
            this.appointments_select.MouseLeave += new System.EventHandler(this.appointments_select_MouseLeave);
            // 
            // products_select
            // 
            this.products_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.products_select.Image = global::DBapplication.Properties.Resources.Select_med;
            this.products_select.Location = new System.Drawing.Point(189, 66);
            this.products_select.Name = "products_select";
            this.products_select.Size = new System.Drawing.Size(95, 30);
            this.products_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.products_select.TabIndex = 35;
            this.products_select.TabStop = false;
            this.products_select.Visible = false;
            this.products_select.Click += new System.EventHandler(this.products_select_Click);
            this.products_select.MouseLeave += new System.EventHandler(this.products_select_MouseLeave);
            // 
            // quiz_select
            // 
            this.quiz_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.quiz_select.Image = global::DBapplication.Properties.Resources.Select_S;
            this.quiz_select.Location = new System.Drawing.Point(510, 66);
            this.quiz_select.Name = "quiz_select";
            this.quiz_select.Size = new System.Drawing.Size(83, 30);
            this.quiz_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.quiz_select.TabIndex = 34;
            this.quiz_select.TabStop = false;
            this.quiz_select.Visible = false;
            this.quiz_select.MouseLeave += new System.EventHandler(this.quiz_select_MouseLeave);
            // 
            // profile_select
            // 
            this.profile_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.profile_select.Image = global::DBapplication.Properties.Resources.Select_med;
            this.profile_select.Location = new System.Drawing.Point(620, 66);
            this.profile_select.Name = "profile_select";
            this.profile_select.Size = new System.Drawing.Size(95, 30);
            this.profile_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_select.TabIndex = 32;
            this.profile_select.TabStop = false;
            this.profile_select.Visible = false;
            this.profile_select.MouseLeave += new System.EventHandler(this.profile_nav_selected_MouseLeave);
            // 
            // pets_select
            // 
            this.pets_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.pets_select.Image = global::DBapplication.Properties.Resources.Select_S;
            this.pets_select.Location = new System.Drawing.Point(72, 66);
            this.pets_select.Name = "pets_select";
            this.pets_select.Size = new System.Drawing.Size(83, 30);
            this.pets_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pets_select.TabIndex = 10;
            this.pets_select.TabStop = false;
            this.pets_select.Visible = false;
            this.pets_select.Click += new System.EventHandler(this.pets_nav_selected_Click);
            this.pets_select.MouseLeave += new System.EventHandler(this.pets_select_MouseLeave);
            // 
            // NavBar
            // 
            this.NavBar.Image = global::DBapplication.Properties.Resources.NavBar;
            this.NavBar.Location = new System.Drawing.Point(48, 57);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(689, 50);
            this.NavBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NavBar.TabIndex = 3;
            this.NavBar.TabStop = false;
            // 
            // hamtamro
            // 
            this.hamtamro.Image = global::DBapplication.Properties.Resources.hamtaro_2;
            this.hamtamro.Location = new System.Drawing.Point(12, 20);
            this.hamtamro.Name = "hamtamro";
            this.hamtamro.Size = new System.Drawing.Size(37, 25);
            this.hamtamro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hamtamro.TabIndex = 2;
            this.hamtamro.TabStop = false;
            // 
            // pet_image
            // 
            this.pet_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.pet_image.Image = global::DBapplication.Properties.Resources.WhatsApp_Image_2023_11_26_at_23_10_1;
            this.pet_image.Location = new System.Drawing.Point(63, 147);
            this.pet_image.Name = "pet_image";
            this.pet_image.Size = new System.Drawing.Size(275, 344);
            this.pet_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pet_image.TabIndex = 60;
            this.pet_image.TabStop = false;
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.type_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.type_label.Location = new System.Drawing.Point(370, 190);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(75, 28);
            this.type_label.TabIndex = 62;
            this.type_label.Text = "Type:  ";
            // 
            // breed_label
            // 
            this.breed_label.AutoSize = true;
            this.breed_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.breed_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.breed_label.Location = new System.Drawing.Point(370, 218);
            this.breed_label.Name = "breed_label";
            this.breed_label.Size = new System.Drawing.Size(85, 28);
            this.breed_label.TabIndex = 63;
            this.breed_label.Text = "Breed:  ";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.age_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.age_label.Location = new System.Drawing.Point(370, 246);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(64, 28);
            this.age_label.TabIndex = 64;
            this.age_label.Text = "Age:  ";
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.gender_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.gender_label.Location = new System.Drawing.Point(370, 274);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(100, 28);
            this.gender_label.TabIndex = 65;
            this.gender_label.Text = "Gender:  ";
            // 
            // goback_button
            // 
            this.goback_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.goback_button.Image = global::DBapplication.Properties.Resources.button;
            this.goback_button.Location = new System.Drawing.Point(723, 473);
            this.goback_button.Name = "goback_button";
            this.goback_button.Size = new System.Drawing.Size(108, 28);
            this.goback_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goback_button.TabIndex = 72;
            this.goback_button.TabStop = false;
            this.goback_button.Click += new System.EventHandler(this.goback_button_Click);
            // 
            // goback_label
            // 
            this.goback_label.AutoSize = true;
            this.goback_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.goback_label.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.goback_label.Location = new System.Drawing.Point(736, 475);
            this.goback_label.Name = "goback_label";
            this.goback_label.Size = new System.Drawing.Size(82, 25);
            this.goback_label.TabIndex = 74;
            this.goback_label.Text = "Go Back";
            this.goback_label.Click += new System.EventHandler(this.goback_button_Click);
            // 
            // disown_button
            // 
            this.disown_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.disown_button.Image = global::DBapplication.Properties.Resources.button;
            this.disown_button.Location = new System.Drawing.Point(648, 156);
            this.disown_button.Name = "disown_button";
            this.disown_button.Size = new System.Drawing.Size(108, 28);
            this.disown_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.disown_button.TabIndex = 70;
            this.disown_button.TabStop = false;
            this.disown_button.Click += new System.EventHandler(this.disown_button_Click);
            // 
            // disown_label
            // 
            this.disown_label.AutoSize = true;
            this.disown_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.disown_label.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disown_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.disown_label.Location = new System.Drawing.Point(664, 158);
            this.disown_label.Name = "disown_label";
            this.disown_label.Size = new System.Drawing.Size(77, 25);
            this.disown_label.TabIndex = 73;
            this.disown_label.Text = "Disown";
            this.disown_label.Click += new System.EventHandler(this.disown_button_Click);
            // 
            // centers_list
            // 
            this.centers_list.BackColor = System.Drawing.Color.White;
            this.centers_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.centers_list.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.centers_list.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.centers_list.FormattingEnabled = true;
            this.centers_list.Location = new System.Drawing.Point(776, 156);
            this.centers_list.Name = "centers_list";
            this.centers_list.Size = new System.Drawing.Size(147, 28);
            this.centers_list.TabIndex = 75;
            this.centers_list.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggableForm_MouseDown);
            this.centers_list.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DraggableForm_MouseMove);
            this.centers_list.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DraggableForm_MouseUp);
            // 
            // name_text
            // 
            this.name_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.name_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_text.Font = new System.Drawing.Font("Abhaya Libre", 30F, System.Drawing.FontStyle.Bold);
            this.name_text.Location = new System.Drawing.Point(367, 146);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(258, 48);
            this.name_text.TabIndex = 76;
            // 
            // center_icon
            // 
            this.center_icon.Image = global::DBapplication.Properties.Resources.Mediamodifier_Design_Template;
            this.center_icon.Location = new System.Drawing.Point(810, 57);
            this.center_icon.Name = "center_icon";
            this.center_icon.Size = new System.Drawing.Size(50, 50);
            this.center_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.center_icon.TabIndex = 77;
            this.center_icon.TabStop = false;
            this.center_icon.Click += new System.EventHandler(this.center_icon_Click);
            this.center_icon.MouseLeave += new System.EventHandler(this.center_icon_MouseLeave);
            this.center_icon.MouseHover += new System.EventHandler(this.center_icon_MouseHover);
            // 
            // MyPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(205)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1008, 534);
            this.Controls.Add(this.center_icon);
            this.Controls.Add(this.centers_list);
            this.Controls.Add(this.goback_label);
            this.Controls.Add(this.disown_label);
            this.Controls.Add(this.goback_button);
            this.Controls.Add(this.disown_button);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.breed_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.pet_image);
            this.Controls.Add(this.close);
            this.Controls.Add(this.appointments_nav_selected);
            this.Controls.Add(this.appointments_select);
            this.Controls.Add(this.products_nav_selected);
            this.Controls.Add(this.products_select);
            this.Controls.Add(this.profile_nav_selected);
            this.Controls.Add(this.quiz_nav_selected);
            this.Controls.Add(this.quiz_select);
            this.Controls.Add(this.profile_select);
            this.Controls.Add(this.pets_nav_selected);
            this.Controls.Add(this.pets_select);
            this.Controls.Add(this.profile_nav);
            this.Controls.Add(this.appointments_nav);
            this.Controls.Add(this.quiz_nav);
            this.Controls.Add(this.products_nav);
            this.Controls.Add(this.pets_nav);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.PurrfectMatch);
            this.Controls.Add(this.hamtamro);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPet";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pets_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamtamro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goback_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disown_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PurrfectMatch;
        private System.Windows.Forms.PictureBox hamtamro;
        private System.Windows.Forms.PictureBox NavBar;
        private System.Windows.Forms.Label pets_nav;
        private System.Windows.Forms.Label products_nav;
        private System.Windows.Forms.Label quiz_nav;
        private System.Windows.Forms.Label appointments_nav;
        private System.Windows.Forms.Label profile_nav;
        private System.Windows.Forms.PictureBox pets_select;
        private System.Windows.Forms.Label pets_nav_selected;
        private System.Windows.Forms.PictureBox mypet;
        private System.Windows.Forms.Label appointments_nav_selected;
        private System.Windows.Forms.PictureBox appointments_select;
        private System.Windows.Forms.Label products_nav_selected;
        private System.Windows.Forms.PictureBox products_select;
        private System.Windows.Forms.Label profile_nav_selected;
        private System.Windows.Forms.Label quiz_nav_selected;
        private System.Windows.Forms.PictureBox quiz_select;
        private System.Windows.Forms.PictureBox profile_select;
        private PictureBox close;
        private PictureBox background;
        private PictureBox pet_image;
        private Label type_label;
        private Label breed_label;
        private Label age_label;
        private Label gender_label;
        private PictureBox goback_button;
        private Label goback_label;
        private PictureBox disown_button;
        private Label disown_label;
        private ComboBox centers_list;
        private TextBox name_text;
        private PictureBox center_icon;
    }
}