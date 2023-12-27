using System.Drawing;
using System.Windows.Forms;

namespace DBapplication
{
    partial class Customer
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
            this.profile_nav_selected = new System.Windows.Forms.Label();
            this.appointments_nav_selected = new System.Windows.Forms.Label();
            this.quiz_nav_selected = new System.Windows.Forms.Label();
            this.products_nav_selected = new System.Windows.Forms.Label();
            this.pets_nav_selected = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.center_icon = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.mypet = new System.Windows.Forms.PictureBox();
            this.appointments_select = new System.Windows.Forms.PictureBox();
            this.products_select = new System.Windows.Forms.PictureBox();
            this.pets_select = new System.Windows.Forms.PictureBox();
            this.quiz_select = new System.Windows.Forms.PictureBox();
            this.profile_select = new System.Windows.Forms.PictureBox();
            this.NavBar = new System.Windows.Forms.PictureBox();
            this.hamtamro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.center_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pets_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_select)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamtamro)).BeginInit();
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
            this.pets_nav.Click += new System.EventHandler(this.pets_nav_selected_Click);
            this.pets_nav.MouseHover += new System.EventHandler(this.pets_nav_Hover);
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
            // profile_nav_selected
            // 
            this.profile_nav_selected.AutoSize = true;
            this.profile_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.profile_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.profile_nav_selected.Location = new System.Drawing.Point(631, 69);
            this.profile_nav_selected.Name = "profile_nav_selected";
            this.profile_nav_selected.Size = new System.Drawing.Size(72, 25);
            this.profile_nav_selected.TabIndex = 19;
            this.profile_nav_selected.Text = "Profile";
            this.profile_nav_selected.Visible = false;
            this.profile_nav_selected.MouseLeave += new System.EventHandler(this.profile_nav_selected_MouseLeave);
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
            this.appointments_nav_selected.TabIndex = 18;
            this.appointments_nav_selected.Text = "Appointments";
            this.appointments_nav_selected.Visible = false;
            this.appointments_nav_selected.Click += new System.EventHandler(this.appointments_nav_selected_Click);
            this.appointments_nav_selected.MouseLeave += new System.EventHandler(this.appointments_select_MouseLeave);
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
            this.quiz_nav_selected.TabIndex = 17;
            this.quiz_nav_selected.Text = "Quiz";
            this.quiz_nav_selected.Visible = false;
            this.quiz_nav_selected.MouseLeave += new System.EventHandler(this.quiz_select_MouseLeave);
            // 
            // products_nav_selected
            // 
            this.products_nav_selected.AutoSize = true;
            this.products_nav_selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(62)))), ((int)(((byte)(179)))));
            this.products_nav_selected.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_nav_selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.products_nav_selected.Location = new System.Drawing.Point(188, 69);
            this.products_nav_selected.Name = "products_nav_selected";
            this.products_nav_selected.Size = new System.Drawing.Size(90, 25);
            this.products_nav_selected.TabIndex = 16;
            this.products_nav_selected.Text = "Products";
            this.products_nav_selected.Visible = false;
            this.products_nav_selected.Click += new System.EventHandler(this.products_nav_Click);
            this.products_nav_selected.MouseLeave += new System.EventHandler(this.products_select_MouseLeave);
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
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 70F, System.Drawing.FontStyle.Bold);
            this.welcome_label.Location = new System.Drawing.Point(53, 154);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(420, 111);
            this.welcome_label.TabIndex = 22;
            this.welcome_label.Text = "Welcome,";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Abhaya Libre SemiBold", 70F, System.Drawing.FontStyle.Bold);
            this.name_label.Location = new System.Drawing.Point(53, 265);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(358, 111);
            this.name_label.TabIndex = 23;
            this.name_label.Text = "*NAME*";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // center_icon
            // 
            this.center_icon.Image = global::DBapplication.Properties.Resources.Mediamodifier_Design_Template;
            this.center_icon.Location = new System.Drawing.Point(810, 57);
            this.center_icon.Name = "center_icon";
            this.center_icon.Size = new System.Drawing.Size(50, 50);
            this.center_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.center_icon.TabIndex = 25;
            this.center_icon.TabStop = false;
            this.center_icon.Click += new System.EventHandler(this.center_icon_Click);
            this.center_icon.MouseLeave += new System.EventHandler(this.center_icon_MouseLeave);
            this.center_icon.MouseHover += new System.EventHandler(this.center_icon_MouseHover);
            // 
            // close
            // 
            this.close.Image = global::DBapplication.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(954, 24);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 22);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 24;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
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
            // appointments_select
            // 
            this.appointments_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.appointments_select.Image = global::DBapplication.Properties.Resources.Select;
            this.appointments_select.Location = new System.Drawing.Point(325, 66);
            this.appointments_select.Name = "appointments_select";
            this.appointments_select.Size = new System.Drawing.Size(155, 30);
            this.appointments_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appointments_select.TabIndex = 12;
            this.appointments_select.TabStop = false;
            this.appointments_select.Visible = false;
            this.appointments_select.Click += new System.EventHandler(this.appointments_nav_selected_Click);
            this.appointments_select.MouseLeave += new System.EventHandler(this.appointments_select_MouseLeave);
            // 
            // products_select
            // 
            this.products_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.products_select.Image = global::DBapplication.Properties.Resources.Select_med;
            this.products_select.Location = new System.Drawing.Point(186, 66);
            this.products_select.Name = "products_select";
            this.products_select.Size = new System.Drawing.Size(95, 30);
            this.products_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.products_select.TabIndex = 14;
            this.products_select.TabStop = false;
            this.products_select.Visible = false;
            this.products_select.Click += new System.EventHandler(this.products_nav_Click);
            this.products_select.MouseLeave += new System.EventHandler(this.products_select_MouseLeave);
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
            // quiz_select
            // 
            this.quiz_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            this.quiz_select.Image = global::DBapplication.Properties.Resources.Select_S;
            this.quiz_select.Location = new System.Drawing.Point(510, 66);
            this.quiz_select.Name = "quiz_select";
            this.quiz_select.Size = new System.Drawing.Size(83, 30);
            this.quiz_select.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.quiz_select.TabIndex = 13;
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
            this.profile_select.TabIndex = 11;
            this.profile_select.TabStop = false;
            this.profile_select.Visible = false;
            this.profile_select.MouseLeave += new System.EventHandler(this.profile_nav_selected_MouseLeave);
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
            this.NavBar.MouseHover += new System.EventHandler(this.profile_nav_MouseHover);
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
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(205)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1008, 534);
            this.Controls.Add(this.center_icon);
            this.Controls.Add(this.close);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.mypet);
            this.Controls.Add(this.appointments_nav_selected);
            this.Controls.Add(this.appointments_select);
            this.Controls.Add(this.products_nav_selected);
            this.Controls.Add(this.products_select);
            this.Controls.Add(this.pets_nav_selected);
            this.Controls.Add(this.pets_select);
            this.Controls.Add(this.profile_nav_selected);
            this.Controls.Add(this.quiz_nav_selected);
            this.Controls.Add(this.quiz_select);
            this.Controls.Add(this.profile_select);
            this.Controls.Add(this.profile_nav);
            this.Controls.Add(this.appointments_nav);
            this.Controls.Add(this.quiz_nav);
            this.Controls.Add(this.products_nav);
            this.Controls.Add(this.pets_nav);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.PurrfectMatch);
            this.Controls.Add(this.hamtamro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggableForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DraggableForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DraggableForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.center_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mypet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pets_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quiz_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_select)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamtamro)).EndInit();
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
        private System.Windows.Forms.PictureBox profile_select;
        private System.Windows.Forms.PictureBox appointments_select;
        private System.Windows.Forms.PictureBox quiz_select;
        private System.Windows.Forms.PictureBox products_select;
        private System.Windows.Forms.Label profile_nav_selected;
        private System.Windows.Forms.Label appointments_nav_selected;
        private System.Windows.Forms.Label quiz_nav_selected;
        private System.Windows.Forms.Label products_nav_selected;
        private System.Windows.Forms.Label pets_nav_selected;
        private System.Windows.Forms.PictureBox mypet;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox close;
        private PictureBox center_icon;
    }
}