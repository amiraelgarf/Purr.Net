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

    public partial class Quiz : Form
    {
        Controller controllerObj;
        int custID;
        Pets mypett;
        string Username;
        public Quiz(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Username = username;
            custID = controllerObj.GetCustomerID(username);
            mypett = new Pets(username);
        }




        private void nextquizbutton_Click(object sender, EventArgs e)
        {
            string a =controllerObj. returnPersonality(custID);
            MessageBox.Show("You personality is " + a + " and your Purrfect Match isss");
            ViewResult p = new ViewResult(Username, a);
            p.FilterPetsByBestFor(a);
            this.Hide();
            p.ShowDialog();
            this.Close();

        }

        private void verylowq1_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertverylow(custID, "Energy");
        }

        private void lowq1_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertlow(custID, "Energy");
        }

        private void mediumq1_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertmedium(custID, "Energy");
        }

        private void highq1_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.inserthigh(custID, "Energy");
        }

        private void veryhighq1_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertveryhigh(custID, "Energy");
        }

        private void verylowq3_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertverylow(custID, "Nature");
        }

        private void verylowq2_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertverylow(custID, "Mind");
        }

        private void lowq2_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertlow(custID, "Mind");
        }

        private void mediumq2_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertmedium(custID, "Mind");
        }

        private void highq2_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.inserthigh(custID, "Mind");
        }

        private void veryhighq2_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertveryhigh(custID, "Mind");
        }

        private void lowq3_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertlow(custID, "Nature");
        }

        private void mediumq3_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertmedium(custID, "Nature");
        }

        private void highq3_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.inserthigh(custID, "Nature");
        }

        private void veryhighq3_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertveryhigh(custID, "Nature");
        }

        private void verylowq4_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertverylow(custID, "Identityy");
        }

        private void lowq4_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertlow(custID, "Identityy");
        }

        private void mediumq4_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertmedium(custID, "Identityy");
        }

        private void highq4_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.inserthigh(custID, "Identityy");
        }

        private void veryhighq4_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertveryhigh(custID, "Identityy");
        }

        private void verylowq5_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertverylow(custID, "Tactics");
        }

        private void lowq5_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertlow(custID, "Tactics");
        }

        private void mediumq5_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertmedium(custID, "Tactics");
        }

        private void highq5_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.inserthigh(custID, "Tactics");
        }

        private void veryhighq5_CheckedChanged(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.insertveryhigh(custID, "Tactics");
        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }
    }

}
