using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Admin : Form
    {
        string AdminUsername;
        public Admin( string username)
        {
            InitializeComponent();

            AdminUsername = username;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminAddDeleteCenter a = new AdminAddDeleteCenter(AdminUsername);
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterRemoveManager a = new RegisterRemoveManager(AdminUsername);
            this.Hide();
            a.ShowDialog();
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterRemoveVet a = new RegisterRemoveVet(AdminUsername);
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartForm a = new StartForm();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePassowrd C = new ChangePassowrd(AdminUsername);
            C.ShowDialog();
        }
    }
}
