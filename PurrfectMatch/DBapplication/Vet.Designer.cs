namespace DBapplication
{
    partial class Vet
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
            this.editdaysandtime = new System.Windows.Forms.Button();
            this.viewappsched = new System.Windows.Forms.Button();
            this.viewratings = new System.Windows.Forms.Button();
            this.ViewApp_ViewRatings = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewApp_ViewRatings)).BeginInit();
            this.SuspendLayout();
            // 
            // editdaysandtime
            // 
            this.editdaysandtime.Location = new System.Drawing.Point(364, 354);
            this.editdaysandtime.Name = "editdaysandtime";
            this.editdaysandtime.Size = new System.Drawing.Size(183, 24);
            this.editdaysandtime.TabIndex = 0;
            this.editdaysandtime.Text = "Delete available date";
            this.editdaysandtime.UseVisualStyleBackColor = true;
            this.editdaysandtime.Click += new System.EventHandler(this.editdaysandtime_Click);
            // 
            // viewappsched
            // 
            this.viewappsched.Location = new System.Drawing.Point(431, 253);
            this.viewappsched.Name = "viewappsched";
            this.viewappsched.Size = new System.Drawing.Size(347, 24);
            this.viewappsched.TabIndex = 1;
            this.viewappsched.Text = "View appointment scedule ";
            this.viewappsched.UseVisualStyleBackColor = true;
            this.viewappsched.Click += new System.EventHandler(this.viewappsched_Click);
            // 
            // viewratings
            // 
            this.viewratings.Location = new System.Drawing.Point(28, 253);
            this.viewratings.Name = "viewratings";
            this.viewratings.Size = new System.Drawing.Size(347, 25);
            this.viewratings.TabIndex = 2;
            this.viewratings.Text = "View ratings";
            this.viewratings.UseVisualStyleBackColor = true;
            this.viewratings.Click += new System.EventHandler(this.viewratings_Click);
            // 
            // ViewApp_ViewRatings
            // 
            this.ViewApp_ViewRatings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewApp_ViewRatings.Location = new System.Drawing.Point(109, 36);
            this.ViewApp_ViewRatings.Name = "ViewApp_ViewRatings";
            this.ViewApp_ViewRatings.RowHeadersWidth = 51;
            this.ViewApp_ViewRatings.RowTemplate.Height = 24;
            this.ViewApp_ViewRatings.Size = new System.Drawing.Size(560, 166);
            this.ViewApp_ViewRatings.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Insert available date";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Vet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ViewApp_ViewRatings);
            this.Controls.Add(this.viewratings);
            this.Controls.Add(this.viewappsched);
            this.Controls.Add(this.editdaysandtime);
            this.Name = "Vet";
            this.Text = "Vet";
            ((System.ComponentModel.ISupportInitialize)(this.ViewApp_ViewRatings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editdaysandtime;
        private System.Windows.Forms.Button viewappsched;
        private System.Windows.Forms.Button viewratings;
        private System.Windows.Forms.DataGridView ViewApp_ViewRatings;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}