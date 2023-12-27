using System.Windows.Forms;

namespace DBapplication
{
    partial class ViewProduct
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
            this.product_image = new System.Windows.Forms.PictureBox();
            this.product_name_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.description_text_label = new System.Windows.Forms.Label();
            this.buy_button = new System.Windows.Forms.PictureBox();
            this.goback_button = new System.Windows.Forms.PictureBox();
            this.buy_label = new System.Windows.Forms.Label();
            this.goback_label = new System.Windows.Forms.Label();
            this.stock_label = new System.Windows.Forms.Label();
            this.description_history = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.quantity_text = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.cost_label = new System.Windows.Forms.Label();
            this.center_label = new System.Windows.Forms.Label();
            this.center_icon = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.product_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goback_button)).BeginInit();
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
            // product_image
            // 
            this.product_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.product_image.Image = global::DBapplication.Properties.Resources.WhatsApp_Image_2023_11_26_at_23_10_1;
            this.product_image.Location = new System.Drawing.Point(63, 147);
            this.product_image.Name = "product_image";
            this.product_image.Size = new System.Drawing.Size(275, 344);
            this.product_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_image.TabIndex = 60;
            this.product_image.TabStop = false;
            // 
            // product_name_label
            // 
            this.product_name_label.AutoSize = true;
            this.product_name_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.product_name_label.Font = new System.Drawing.Font("Abhaya Libre", 30F, System.Drawing.FontStyle.Bold);
            this.product_name_label.Location = new System.Drawing.Point(367, 146);
            this.product_name_label.Name = "product_name_label";
            this.product_name_label.Size = new System.Drawing.Size(331, 48);
            this.product_name_label.TabIndex = 61;
            this.product_name_label.Text = "*PRODUCT NAME*";
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
            // description_text_label
            // 
            this.description_text_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.description_text_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.description_text_label.Location = new System.Drawing.Point(370, 356);
            this.description_text_label.Name = "description_text_label";
            this.description_text_label.Size = new System.Drawing.Size(572, 114);
            this.description_text_label.TabIndex = 69;
            this.description_text_label.Text = "*TEXT*";
            // 
            // buy_button
            // 
            this.buy_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.buy_button.Image = global::DBapplication.Properties.Resources.button;
            this.buy_button.Location = new System.Drawing.Point(500, 473);
            this.buy_button.Name = "buy_button";
            this.buy_button.Size = new System.Drawing.Size(108, 28);
            this.buy_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buy_button.TabIndex = 70;
            this.buy_button.TabStop = false;
            this.buy_button.Click += new System.EventHandler(this.buy_button_Click);
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
            // buy_label
            // 
            this.buy_label.AutoSize = true;
            this.buy_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.buy_label.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.buy_label.Location = new System.Drawing.Point(531, 475);
            this.buy_label.Name = "buy_label";
            this.buy_label.Size = new System.Drawing.Size(46, 25);
            this.buy_label.TabIndex = 73;
            this.buy_label.Text = "Buy";
            this.buy_label.Click += new System.EventHandler(this.buy_button_Click);
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
            // stock_label
            // 
            this.stock_label.AutoSize = true;
            this.stock_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.stock_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.stock_label.Location = new System.Drawing.Point(370, 274);
            this.stock_label.Name = "stock_label";
            this.stock_label.Size = new System.Drawing.Size(82, 28);
            this.stock_label.TabIndex = 66;
            this.stock_label.Text = "Stock:  ";
            this.stock_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // description_history
            // 
            this.description_history.AutoSize = true;
            this.description_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.description_history.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.description_history.Location = new System.Drawing.Point(370, 328);
            this.description_history.Name = "description_history";
            this.description_history.Size = new System.Drawing.Size(137, 28);
            this.description_history.TabIndex = 68;
            this.description_history.Text = "Description: ";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.price_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.price_label.Location = new System.Drawing.Point(370, 218);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(77, 28);
            this.price_label.TabIndex = 75;
            this.price_label.Text = "Price:  ";
            // 
            // quantity_text
            // 
            this.quantity_text.Font = new System.Drawing.Font("Arial Narrow", 13.5F, System.Drawing.FontStyle.Bold);
            this.quantity_text.Location = new System.Drawing.Point(458, 473);
            this.quantity_text.Name = "quantity_text";
            this.quantity_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.quantity_text.Size = new System.Drawing.Size(31, 28);
            this.quantity_text.TabIndex = 76;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.quantity_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.quantity_label.Location = new System.Drawing.Point(354, 473);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(110, 28);
            this.quantity_label.TabIndex = 77;
            this.quantity_label.Text = "Quantity: ";
            // 
            // cost_label
            // 
            this.cost_label.AutoSize = true;
            this.cost_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.cost_label.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_label.Location = new System.Drawing.Point(434, 218);
            this.cost_label.Name = "cost_label";
            this.cost_label.Size = new System.Drawing.Size(24, 28);
            this.cost_label.TabIndex = 78;
            this.cost_label.Text = "$";
            // 
            // center_label
            // 
            this.center_label.AutoSize = true;
            this.center_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.center_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.center_label.Location = new System.Drawing.Point(370, 246);
            this.center_label.Name = "center_label";
            this.center_label.Size = new System.Drawing.Size(94, 28);
            this.center_label.TabIndex = 79;
            this.center_label.Text = "Center:  ";
            // 
            // center_icon
            // 
            this.center_icon.Image = global::DBapplication.Properties.Resources.Mediamodifier_Design_Template;
            this.center_icon.Location = new System.Drawing.Point(810, 57);
            this.center_icon.Name = "center_icon";
            this.center_icon.Size = new System.Drawing.Size(50, 50);
            this.center_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.center_icon.TabIndex = 80;
            this.center_icon.TabStop = false;
            this.center_icon.Click += new System.EventHandler(this.center_icon_Click);
            this.center_icon.MouseLeave += new System.EventHandler(this.center_icon_MouseLeave);
            this.center_icon.MouseHover += new System.EventHandler(this.center_icon_MouseHover);
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(205)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1008, 534);
            this.Controls.Add(this.center_icon);
            this.Controls.Add(this.center_label);
            this.Controls.Add(this.cost_label);
            this.Controls.Add(this.quantity_text);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.goback_label);
            this.Controls.Add(this.buy_label);
            this.Controls.Add(this.goback_button);
            this.Controls.Add(this.buy_button);
            this.Controls.Add(this.description_text_label);
            this.Controls.Add(this.description_history);
            this.Controls.Add(this.stock_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.product_name_label);
            this.Controls.Add(this.product_image);
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
            this.Name = "ViewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProduct";
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
            ((System.ComponentModel.ISupportInitialize)(this.product_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goback_button)).EndInit();
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
        private PictureBox product_image;
        private Label product_name_label;
        private Label type_label;
        private Label description_text_label;
        private PictureBox buy_button;
        private PictureBox goback_button;
        private Label buy_label;
        private Label goback_label;
        private Label stock_label;
        private Label description_history;
        private Label price_label;
        private TextBox quantity_text;
        private Label quantity_label;
        private Label cost_label;
        private Label center_label;
        private PictureBox center_icon;
    }
}