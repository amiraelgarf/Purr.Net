namespace DBapplication
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Next = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "password";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(177, 102);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(232, 22);
            this.fName.TabIndex = 6;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(177, 148);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(232, 22);
            this.lName.TabIndex = 7;
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(177, 194);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(232, 22);
            this.Gender.TabIndex = 8;
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(177, 237);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(232, 22);
            this.DOB.TabIndex = 9;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(177, 290);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(232, 22);
            this.username.TabIndex = 10;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(177, 336);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(232, 22);
            this.password.TabIndex = 11;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(379, 435);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(145, 30);
            this.Next.TabIndex = 12;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox DOB;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button button1;
    }
}