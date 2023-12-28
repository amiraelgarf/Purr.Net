using System.Windows.Forms;

namespace DBapplication
{
    partial class Profile
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
            this.mypet = new System.Windows.Forms.PictureBox();
            this.pets_select = new System.Windows.Forms.PictureBox();
            this.NavBar = new System.Windows.Forms.PictureBox();
            this.hamtamro = new System.Windows.Forms.PictureBox();
            this.pet_image = new System.Windows.Forms.PictureBox();
            this.gender_label = new System.Windows.Forms.Label();
            this.personality_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.PictureBox();
            this.save_label = new System.Windows.Forms.Label();
            this.center_icon = new System.Windows.Forms.PictureBox();
            this.dateofbirth_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.confirmpassword_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.PictureBox();
            this.goback_label = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.confirmpassword_text = new System.Windows.Forms.TextBox();
            this.date_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.age_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pets_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamtamro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_button)).BeginInit();
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
            this.pets_nav_selected.Click += new System.EventHandler(this.pets_select_Click);
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
            this.appointments_nav_selected.Click += new System.EventHandler(this.appointments_select_Click);
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
            this.appointments_select.Click += new System.EventHandler(this.appointments_select_Click);
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
            // 
            // mypet
            // 
            this.mypet.Image = global::DBapplication.Properties.Resources.Paw_3_1;
            this.mypet.Location = new System.Drawing.Point(902, 57);
            this.mypet.Name = "mypet";
            this.mypet.Size = new System.Drawing.Size(52, 50);
            this.mypet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mypet.TabIndex = 21;
            this.mypet.TabStop = false;
            this.mypet.Click += new System.EventHandler(this.mypet_Click);
            this.mypet.MouseLeave += new System.EventHandler(this.mypet_MouseLeave);
            this.mypet.MouseHover += new System.EventHandler(this.mypet_MouseHover);
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
            this.pets_select.Click += new System.EventHandler(this.pets_select_Click);
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
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.gender_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.gender_label.Location = new System.Drawing.Point(370, 332);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(90, 28);
            this.gender_label.TabIndex = 65;
            this.gender_label.Text = "Gender:";
            // 
            // personality_label
            // 
            this.personality_label.AutoSize = true;
            this.personality_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.personality_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.personality_label.Location = new System.Drawing.Point(370, 360);
            this.personality_label.Name = "personality_label";
            this.personality_label.Size = new System.Drawing.Size(138, 28);
            this.personality_label.TabIndex = 67;
            this.personality_label.Text = "Personality:  ";
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.save_button.Image = global::DBapplication.Properties.Resources.button;
            this.save_button.Location = new System.Drawing.Point(500, 473);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(108, 28);
            this.save_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.save_button.TabIndex = 70;
            this.save_button.TabStop = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // save_label
            // 
            this.save_label.AutoSize = true;
            this.save_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.save_label.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.save_label.Location = new System.Drawing.Point(528, 475);
            this.save_label.Name = "save_label";
            this.save_label.Size = new System.Drawing.Size(53, 25);
            this.save_label.TabIndex = 73;
            this.save_label.Text = "Save";
            this.save_label.Click += new System.EventHandler(this.save_button_Click);
            // 
            // center_icon
            // 
            this.center_icon.Image = global::DBapplication.Properties.Resources.Mediamodifier_Design_Template;
            this.center_icon.Location = new System.Drawing.Point(810, 57);
            this.center_icon.Name = "center_icon";
            this.center_icon.Size = new System.Drawing.Size(50, 50);
            this.center_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.center_icon.TabIndex = 75;
            this.center_icon.TabStop = false;
            this.center_icon.Click += new System.EventHandler(this.center_icon_Click);
            this.center_icon.MouseLeave += new System.EventHandler(this.center_icon_MouseLeave);
            this.center_icon.MouseHover += new System.EventHandler(this.center_icon_MouseHover);
            // 
            // dateofbirth_label
            // 
            this.dateofbirth_label.AutoSize = true;
            this.dateofbirth_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.dateofbirth_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.dateofbirth_label.Location = new System.Drawing.Point(370, 274);
            this.dateofbirth_label.Name = "dateofbirth_label";
            this.dateofbirth_label.Size = new System.Drawing.Size(143, 28);
            this.dateofbirth_label.TabIndex = 64;
            this.dateofbirth_label.Text = "Date of Birth:";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.username_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.username_label.Location = new System.Drawing.Point(370, 190);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(125, 28);
            this.username_label.TabIndex = 62;
            this.username_label.Text = "Username:  ";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.password_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.password_label.Location = new System.Drawing.Point(370, 218);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(109, 28);
            this.password_label.TabIndex = 76;
            this.password_label.Text = "Password:";
            // 
            // confirmpassword_label
            // 
            this.confirmpassword_label.AutoSize = true;
            this.confirmpassword_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.confirmpassword_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.confirmpassword_label.Location = new System.Drawing.Point(370, 246);
            this.confirmpassword_label.Name = "confirmpassword_label";
            this.confirmpassword_label.Size = new System.Drawing.Size(196, 28);
            this.confirmpassword_label.TabIndex = 77;
            this.confirmpassword_label.Text = "Confirm Password:";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.delete_button.Image = global::DBapplication.Properties.Resources.button;
            this.delete_button.Location = new System.Drawing.Point(723, 473);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(108, 28);
            this.delete_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.delete_button.TabIndex = 72;
            this.delete_button.TabStop = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // goback_label
            // 
            this.goback_label.AutoSize = true;
            this.goback_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.goback_label.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.goback_label.Location = new System.Drawing.Point(743, 475);
            this.goback_label.Name = "goback_label";
            this.goback_label.Size = new System.Drawing.Size(69, 25);
            this.goback_label.TabIndex = 74;
            this.goback_label.Text = "Delete";
            this.goback_label.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // password_text
            // 
            this.password_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.password_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_text.Font = new System.Drawing.Font("Abhaya Libre Medium", 17.5F);
            this.password_text.Location = new System.Drawing.Point(477, 219);
            this.password_text.Margin = new System.Windows.Forms.Padding(0);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(182, 28);
            this.password_text.TabIndex = 78;
            // 
            // confirmpassword_text
            // 
            this.confirmpassword_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.confirmpassword_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmpassword_text.Font = new System.Drawing.Font("Abhaya Libre Medium", 17.5F);
            this.confirmpassword_text.Location = new System.Drawing.Point(566, 247);
            this.confirmpassword_text.Margin = new System.Windows.Forms.Padding(0);
            this.confirmpassword_text.Name = "confirmpassword_text";
            this.confirmpassword_text.Size = new System.Drawing.Size(182, 28);
            this.confirmpassword_text.TabIndex = 79;
            // 
            // date_text
            // 
            this.date_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.date_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date_text.Font = new System.Drawing.Font("Abhaya Libre Medium", 17.5F);
            this.date_text.Location = new System.Drawing.Point(512, 274);
            this.date_text.Margin = new System.Windows.Forms.Padding(0);
            this.date_text.Name = "date_text";
            this.date_text.Size = new System.Drawing.Size(182, 28);
            this.date_text.TabIndex = 80;
            // 
            // name_text
            // 
            this.name_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.name_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_text.Font = new System.Drawing.Font("Abhaya Libre", 30F, System.Drawing.FontStyle.Bold);
            this.name_text.Location = new System.Drawing.Point(367, 146);
            this.name_text.Margin = new System.Windows.Forms.Padding(0);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(321, 48);
            this.name_text.TabIndex = 81;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.age_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.age_label.Location = new System.Drawing.Point(370, 302);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(64, 28);
            this.age_label.TabIndex = 82;
            this.age_label.Text = "Age:  ";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(205)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1008, 534);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.date_text);
            this.Controls.Add(this.confirmpassword_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.confirmpassword_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.center_icon);
            this.Controls.Add(this.goback_label);
            this.Controls.Add(this.save_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.personality_label);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.dateofbirth_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.pet_image);
            this.Controls.Add(this.background);
            this.Controls.Add(this.close);
            this.Controls.Add(this.appointments_nav_selected);
            this.Controls.Add(this.appointments_select);
            this.Controls.Add(this.products_nav_selected);
            this.Controls.Add(this.products_select);
            this.Controls.Add(this.profile_nav_selected);
            this.Controls.Add(this.quiz_nav_selected);
            this.Controls.Add(this.quiz_select);
            this.Controls.Add(this.profile_select);
            this.Controls.Add(this.mypet);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggableForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DraggableForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DraggableForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pets_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamtamro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.center_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_button)).EndInit();
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
        private Label gender_label;
        private Label personality_label;
        private PictureBox save_button;
        private Label save_label;
        private PictureBox center_icon;
        private Label dateofbirth_label;
        private Label username_label;
        private Label password_label;
        private Label confirmpassword_label;
        private PictureBox delete_button;
        private Label goback_label;
        private TextBox password_text;
        private TextBox confirmpassword_text;
        private TextBox date_text;
        private TextBox name_text;
        private Label age_label;
    }
}