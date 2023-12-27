using System.Windows.Forms;

namespace DBapplication
{
    partial class ViewAndEditPetManager
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
            this.gender_label = new System.Windows.Forms.Label();
            this.center_label = new System.Windows.Forms.Label();
            this.personality_label = new System.Windows.Forms.Label();
            this.label_history = new System.Windows.Forms.Label();
            this.save_label = new System.Windows.Forms.Label();
            this.goback_label = new System.Windows.Forms.Label();
            this.breed_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.breed_textbox = new System.Windows.Forms.TextBox();
            this.gender_textbox = new System.Windows.Forms.TextBox();
            this.bestfor_textbox = new System.Windows.Forms.TextBox();
            this.history_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.remove_label = new System.Windows.Forms.Label();
            this.appointments_nav_selected = new System.Windows.Forms.Label();
            this.profile_nav_selected = new System.Windows.Forms.Label();
            this.pets_nav_selected = new System.Windows.Forms.Label();
            this.products_nav_selected = new System.Windows.Forms.Label();
            this.TypeDropDown = new System.Windows.Forms.ComboBox();
            this.CenterDropDown = new System.Windows.Forms.ComboBox();
            this.age_label = new System.Windows.Forms.Label();
            this.age_textbox = new System.Windows.Forms.TextBox();
            this.profile_select = new System.Windows.Forms.PictureBox();
            this.appointments_select = new System.Windows.Forms.PictureBox();
            this.products_select = new System.Windows.Forms.PictureBox();
            this.pets_select = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goback_button = new System.Windows.Forms.PictureBox();
            this.save_button = new System.Windows.Forms.PictureBox();
            this.pet_image = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.hamtamro = new System.Windows.Forms.PictureBox();
            this.profile_nav = new System.Windows.Forms.Label();
            this.appointments_nav = new System.Windows.Forms.Label();
            this.products_nav = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profile_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pets_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goback_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamtamro)).BeginInit();
            this.SuspendLayout();
            // 
            // PurrfectMatch
            // 
            this.PurrfectMatch.AutoSize = true;
            this.PurrfectMatch.BackColor = System.Drawing.Color.Transparent;
            this.PurrfectMatch.Font = new System.Drawing.Font("Abhaya Libre ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.PurrfectMatch.Location = new System.Drawing.Point(57, 25);
            this.PurrfectMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PurrfectMatch.Name = "PurrfectMatch";
            this.PurrfectMatch.Size = new System.Drawing.Size(233, 32);
            this.PurrfectMatch.TabIndex = 0;
            this.PurrfectMatch.Text = "PurrfectMatch.com";
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.gender_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.gender_label.Location = new System.Drawing.Point(493, 337);
            this.gender_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(126, 35);
            this.gender_label.TabIndex = 65;
            this.gender_label.Text = "Gender:  ";
            // 
            // center_label
            // 
            this.center_label.AutoSize = true;
            this.center_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.center_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.center_label.Location = new System.Drawing.Point(493, 372);
            this.center_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.center_label.Name = "center_label";
            this.center_label.Size = new System.Drawing.Size(118, 35);
            this.center_label.TabIndex = 66;
            this.center_label.Text = "Center:  ";
            // 
            // personality_label
            // 
            this.personality_label.AutoSize = true;
            this.personality_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.personality_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.personality_label.Location = new System.Drawing.Point(493, 406);
            this.personality_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personality_label.Name = "personality_label";
            this.personality_label.Size = new System.Drawing.Size(134, 35);
            this.personality_label.TabIndex = 67;
            this.personality_label.Text = "Best For:  ";
            // 
            // label_history
            // 
            this.label_history.AutoSize = true;
            this.label_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.label_history.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.label_history.Location = new System.Drawing.Point(493, 441);
            this.label_history.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_history.Name = "label_history";
            this.label_history.Size = new System.Drawing.Size(114, 35);
            this.label_history.TabIndex = 68;
            this.label_history.Text = "History:";
            // 
            // save_label
            // 
            this.save_label.AutoSize = true;
            this.save_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.save_label.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.save_label.Location = new System.Drawing.Point(599, 584);
            this.save_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.save_label.Name = "save_label";
            this.save_label.Size = new System.Drawing.Size(65, 32);
            this.save_label.TabIndex = 73;
            this.save_label.Text = "Save";
            this.save_label.Click += new System.EventHandler(this.saveedits_button_Click);
            // 
            // goback_label
            // 
            this.goback_label.AutoSize = true;
            this.goback_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.goback_label.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.goback_label.Location = new System.Drawing.Point(981, 585);
            this.goback_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goback_label.Name = "goback_label";
            this.goback_label.Size = new System.Drawing.Size(105, 32);
            this.goback_label.TabIndex = 74;
            this.goback_label.Text = "Go Back";
            this.goback_label.Click += new System.EventHandler(this.goback_button_Click);
            // 
            // breed_label
            // 
            this.breed_label.AutoSize = true;
            this.breed_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.breed_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.breed_label.Location = new System.Drawing.Point(493, 268);
            this.breed_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.breed_label.Name = "breed_label";
            this.breed_label.Size = new System.Drawing.Size(106, 35);
            this.breed_label.TabIndex = 63;
            this.breed_label.Text = "Breed:  ";
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.type_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.type_label.Location = new System.Drawing.Point(493, 234);
            this.type_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(94, 35);
            this.type_label.TabIndex = 62;
            this.type_label.Text = "Type:  ";
            // 
            // breed_textbox
            // 
            this.breed_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.breed_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.breed_textbox.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.breed_textbox.Location = new System.Drawing.Point(585, 268);
            this.breed_textbox.Name = "breed_textbox";
            this.breed_textbox.Size = new System.Drawing.Size(346, 36);
            this.breed_textbox.TabIndex = 76;
            // 
            // gender_textbox
            // 
            this.gender_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.gender_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gender_textbox.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.gender_textbox.Location = new System.Drawing.Point(608, 335);
            this.gender_textbox.Name = "gender_textbox";
            this.gender_textbox.Size = new System.Drawing.Size(346, 36);
            this.gender_textbox.TabIndex = 78;
            // 
            // bestfor_textbox
            // 
            this.bestfor_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.bestfor_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bestfor_textbox.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.bestfor_textbox.Location = new System.Drawing.Point(614, 406);
            this.bestfor_textbox.Name = "bestfor_textbox";
            this.bestfor_textbox.Size = new System.Drawing.Size(346, 36);
            this.bestfor_textbox.TabIndex = 80;
            // 
            // history_textbox
            // 
            this.history_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.history_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.history_textbox.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.history_textbox.Location = new System.Drawing.Point(499, 479);
            this.history_textbox.Multiline = true;
            this.history_textbox.Name = "history_textbox";
            this.history_textbox.Size = new System.Drawing.Size(620, 96);
            this.history_textbox.TabIndex = 81;
            // 
            // name_textbox
            // 
            this.name_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.name_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_textbox.Font = new System.Drawing.Font("Abhaya Libre", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textbox.Location = new System.Drawing.Point(499, 182);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(544, 44);
            this.name_textbox.TabIndex = 82;
            // 
            // remove_label
            // 
            this.remove_label.AutoSize = true;
            this.remove_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(118)))), ((int)(((byte)(129)))));
            this.remove_label.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.remove_label.Location = new System.Drawing.Point(782, 584);
            this.remove_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.remove_label.Name = "remove_label";
            this.remove_label.Size = new System.Drawing.Size(101, 32);
            this.remove_label.TabIndex = 84;
            this.remove_label.Text = "Remove";
            this.remove_label.Click += new System.EventHandler(this.remove_label_Click);
            // 
            // appointments_nav_selected
            // 
            this.appointments_nav_selected.AutoSize = true;
            this.appointments_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.appointments_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointments_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.appointments_nav_selected.Location = new System.Drawing.Point(443, 82);
            this.appointments_nav_selected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appointments_nav_selected.Name = "appointments_nav_selected";
            this.appointments_nav_selected.Size = new System.Drawing.Size(175, 32);
            this.appointments_nav_selected.TabIndex = 92;
            this.appointments_nav_selected.Text = "Appointments";
            this.appointments_nav_selected.Visible = false;
            // 
            // profile_nav_selected
            // 
            this.profile_nav_selected.AutoSize = true;
            this.profile_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.profile_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.profile_nav_selected.Location = new System.Drawing.Point(723, 80);
            this.profile_nav_selected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profile_nav_selected.Name = "profile_nav_selected";
            this.profile_nav_selected.Size = new System.Drawing.Size(90, 32);
            this.profile_nav_selected.TabIndex = 93;
            this.profile_nav_selected.Text = "Profile";
            this.profile_nav_selected.Visible = false;
            // 
            // pets_nav_selected
            // 
            this.pets_nav_selected.AutoSize = true;
            this.pets_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.pets_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pets_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.pets_nav_selected.Location = new System.Drawing.Point(117, 82);
            this.pets_nav_selected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pets_nav_selected.Name = "pets_nav_selected";
            this.pets_nav_selected.Size = new System.Drawing.Size(61, 32);
            this.pets_nav_selected.TabIndex = 88;
            this.pets_nav_selected.Text = "Pets";
            // 
            // products_nav_selected
            // 
            this.products_nav_selected.AutoSize = true;
            this.products_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.products_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.products_nav_selected.Location = new System.Drawing.Point(264, 81);
            this.products_nav_selected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.products_nav_selected.Name = "products_nav_selected";
            this.products_nav_selected.Size = new System.Drawing.Size(116, 32);
            this.products_nav_selected.TabIndex = 94;
            this.products_nav_selected.Text = "Products";
            this.products_nav_selected.Visible = false;
            // 
            // TypeDropDown
            // 
            this.TypeDropDown.FormattingEnabled = true;
            this.TypeDropDown.Location = new System.Drawing.Point(771, 243);
            this.TypeDropDown.Name = "TypeDropDown";
            this.TypeDropDown.Size = new System.Drawing.Size(121, 24);
            this.TypeDropDown.TabIndex = 95;
            // 
            // CenterDropDown
            // 
            this.CenterDropDown.FormattingEnabled = true;
            this.CenterDropDown.Location = new System.Drawing.Point(823, 376);
            this.CenterDropDown.Name = "CenterDropDown";
            this.CenterDropDown.Size = new System.Drawing.Size(121, 24);
            this.CenterDropDown.TabIndex = 96;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.age_label.Font = new System.Drawing.Font("Abhaya Libre Medium", 18F);
            this.age_label.Location = new System.Drawing.Point(493, 303);
            this.age_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(79, 35);
            this.age_label.TabIndex = 64;
            this.age_label.Text = "Age:  ";
            // 
            // age_textbox
            // 
            this.age_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.age_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.age_textbox.Enabled = false;
            this.age_textbox.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 18F, System.Drawing.FontStyle.Bold);
            this.age_textbox.Location = new System.Drawing.Point(557, 299);
            this.age_textbox.Name = "age_textbox";
            this.age_textbox.Size = new System.Drawing.Size(210, 36);
            this.age_textbox.TabIndex = 97;
            this.age_textbox.TextChanged += new System.EventHandler(this.age_textbox_TextChanged);
            // 
            // profile_select
            // 
            this.profile_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.profile_select.Image = global::DBapplication.Properties.Resources.Select_med;
            this.profile_select.Location = new System.Drawing.Point(705, 78);
            this.profile_select.Margin = new System.Windows.Forms.Padding(4);
            this.profile_select.Name = "profile_select";
            this.profile_select.Size = new System.Drawing.Size(127, 37);
            this.profile_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_select.TabIndex = 89;
            this.profile_select.TabStop = false;
            this.profile_select.Visible = false;
            // 
            // appointments_select
            // 
            this.appointments_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.appointments_select.Image = global::DBapplication.Properties.Resources.Select;
            this.appointments_select.Location = new System.Drawing.Point(431, 78);
            this.appointments_select.Margin = new System.Windows.Forms.Padding(4);
            this.appointments_select.Name = "appointments_select";
            this.appointments_select.Size = new System.Drawing.Size(207, 37);
            this.appointments_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appointments_select.TabIndex = 90;
            this.appointments_select.TabStop = false;
            this.appointments_select.Visible = false;
            // 
            // products_select
            // 
            this.products_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.products_select.Image = global::DBapplication.Properties.Resources.Select_med;
            this.products_select.Location = new System.Drawing.Point(260, 77);
            this.products_select.Margin = new System.Windows.Forms.Padding(4);
            this.products_select.Name = "products_select";
            this.products_select.Size = new System.Drawing.Size(127, 40);
            this.products_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.products_select.TabIndex = 91;
            this.products_select.TabStop = false;
            this.products_select.Visible = false;
            // 
            // pets_select
            // 
            this.pets_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.pets_select.Image = global::DBapplication.Properties.Resources.Select_S;
            this.pets_select.Location = new System.Drawing.Point(94, 78);
            this.pets_select.Margin = new System.Windows.Forms.Padding(4);
            this.pets_select.Name = "pets_select";
            this.pets_select.Size = new System.Drawing.Size(111, 37);
            this.pets_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pets_select.TabIndex = 87;
            this.pets_select.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DBapplication.Properties.Resources.NavBar;
            this.pictureBox2.Location = new System.Drawing.Point(62, 67);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(821, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.pictureBox1.Image = global::DBapplication.Properties.Resources.button;
            this.pictureBox1.Location = new System.Drawing.Point(761, 582);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // goback_button
            // 
            this.goback_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.goback_button.Image = global::DBapplication.Properties.Resources.button;
            this.goback_button.Location = new System.Drawing.Point(964, 582);
            this.goback_button.Margin = new System.Windows.Forms.Padding(4);
            this.goback_button.Name = "goback_button";
            this.goback_button.Size = new System.Drawing.Size(144, 34);
            this.goback_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goback_button.TabIndex = 72;
            this.goback_button.TabStop = false;
            this.goback_button.Click += new System.EventHandler(this.goback_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.save_button.Image = global::DBapplication.Properties.Resources.button;
            this.save_button.Location = new System.Drawing.Point(559, 582);
            this.save_button.Margin = new System.Windows.Forms.Padding(4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(144, 34);
            this.save_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.save_button.TabIndex = 70;
            this.save_button.TabStop = false;
            this.save_button.Click += new System.EventHandler(this.saveedits_button_Click);
            // 
            // pet_image
            // 
            this.pet_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.pet_image.Image = global::DBapplication.Properties.Resources.WhatsApp_Image_2023_11_26_at_23_10_1;
            this.pet_image.Location = new System.Drawing.Point(84, 181);
            this.pet_image.Margin = new System.Windows.Forms.Padding(4);
            this.pet_image.Name = "pet_image";
            this.pet_image.Size = new System.Drawing.Size(367, 423);
            this.pet_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pet_image.TabIndex = 60;
            this.pet_image.TabStop = false;
            // 
            // background
            // 
            this.background.Image = global::DBapplication.Properties.Resources.back_2;
            this.background.Location = new System.Drawing.Point(64, 156);
            this.background.Margin = new System.Windows.Forms.Padding(4);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1208, 474);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 59;
            this.background.TabStop = false;
            // 
            // close
            // 
            this.close.Image = global::DBapplication.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(1272, 30);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(29, 27);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 58;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // hamtamro
            // 
            this.hamtamro.Image = global::DBapplication.Properties.Resources.hamtaro_2;
            this.hamtamro.Location = new System.Drawing.Point(16, 25);
            this.hamtamro.Margin = new System.Windows.Forms.Padding(4);
            this.hamtamro.Name = "hamtamro";
            this.hamtamro.Size = new System.Drawing.Size(49, 31);
            this.hamtamro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hamtamro.TabIndex = 2;
            this.hamtamro.TabStop = false;
            // 
            // profile_nav
            // 
            this.profile_nav.AutoSize = true;
            this.profile_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.profile_nav.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_nav.Location = new System.Drawing.Point(707, 82);
            this.profile_nav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.profile_nav.Name = "profile_nav";
            this.profile_nav.Size = new System.Drawing.Size(90, 32);
            this.profile_nav.TabIndex = 100;
            this.profile_nav.Text = "Profile";
            // 
            // appointments_nav
            // 
            this.appointments_nav.AutoSize = true;
            this.appointments_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.appointments_nav.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointments_nav.Location = new System.Drawing.Point(444, 82);
            this.appointments_nav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appointments_nav.Name = "appointments_nav";
            this.appointments_nav.Size = new System.Drawing.Size(175, 32);
            this.appointments_nav.TabIndex = 99;
            this.appointments_nav.Text = "Appointments";
            // 
            // products_nav
            // 
            this.products_nav.AutoSize = true;
            this.products_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.products_nav.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_nav.Location = new System.Drawing.Point(254, 82);
            this.products_nav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.products_nav.Name = "products_nav";
            this.products_nav.Size = new System.Drawing.Size(116, 32);
            this.products_nav.TabIndex = 98;
            this.products_nav.Text = "Products";
            // 
            // ViewAndEditPetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(205)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1344, 657);
            this.Controls.Add(this.age_textbox);
            this.Controls.Add(this.CenterDropDown);
            this.Controls.Add(this.TypeDropDown);
            this.Controls.Add(this.products_nav_selected);
            this.Controls.Add(this.profile_nav_selected);
            this.Controls.Add(this.profile_select);
            this.Controls.Add(this.appointments_nav_selected);
            this.Controls.Add(this.appointments_select);
            this.Controls.Add(this.products_select);
            this.Controls.Add(this.pets_nav_selected);
            this.Controls.Add(this.pets_select);
            this.Controls.Add(this.remove_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.bestfor_textbox);
            this.Controls.Add(this.personality_label);
            this.Controls.Add(this.history_textbox);
            this.Controls.Add(this.gender_textbox);
            this.Controls.Add(this.breed_textbox);
            this.Controls.Add(this.goback_label);
            this.Controls.Add(this.save_label);
            this.Controls.Add(this.goback_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label_history);
            this.Controls.Add(this.center_label);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.breed_label);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.pet_image);
            this.Controls.Add(this.background);
            this.Controls.Add(this.close);
            this.Controls.Add(this.PurrfectMatch);
            this.Controls.Add(this.hamtamro);
            this.Controls.Add(this.profile_nav);
            this.Controls.Add(this.appointments_nav);
            this.Controls.Add(this.products_nav);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAndEditPetManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPetManager";
            ((System.ComponentModel.ISupportInitialize)(this.profile_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pets_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goback_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pet_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamtamro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PurrfectMatch;
        private System.Windows.Forms.PictureBox hamtamro;
        private PictureBox close;
        private PictureBox background;
        private PictureBox pet_image;
        private Label gender_label;
        private Label center_label;
        private Label personality_label;
        private Label label_history;
        private PictureBox save_button;
        private PictureBox goback_button;
        private Label save_label;
        private Label goback_label;
        private Label breed_label;
        private Label type_label;
        private TextBox breed_textbox;
        private TextBox gender_textbox;
        private TextBox bestfor_textbox;
        private TextBox history_textbox;
        private TextBox name_textbox;
        private PictureBox pictureBox1;
        private Label remove_label;
        private Label appointments_nav_selected;
        private PictureBox appointments_select;
        private PictureBox products_select;
        private Label profile_nav_selected;
        private PictureBox profile_select;
        private Label pets_nav_selected;
        private PictureBox pets_select;
        private PictureBox pictureBox2;
        private Label products_nav_selected;
        private ComboBox TypeDropDown;
        private ComboBox CenterDropDown;
        private Label age_label;
        private TextBox age_textbox;
        private Label profile_nav;
        private Label appointments_nav;
        private Label products_nav;
    }
}