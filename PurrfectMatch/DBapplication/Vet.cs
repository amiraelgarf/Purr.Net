using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace DBapplication
{


    public partial class Vet : Form
    {
        DataTable vet;
        int vetID;
        Controller controllerObj;
        public Vet(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            vetID = controllerObj.GetVetID(username);
            DataTable dt1 = controllerObj.SelectAvailableDates(vetID);
            comboBox1.DisplayMember = "Datee";
            comboBox1.ValueMember = "Datee";
            comboBox1.DataSource = dt1;

        }

        private void editdaysandtime_Click(object sender, EventArgs e)
        {
            
            int r = controllerObj.DeleteAvailableDate(vetID, Convert.ToString(comboBox1.SelectedValue));
            if (r == 0)
            {
                MessageBox.Show("failed to delete");
            }
            else
            {
                MessageBox.Show("deleted successfully");
            }
        }

        private void viewappsched_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectSchedule(vetID);
            ViewApp_ViewRatings.DataSource = dt;
            ViewApp_ViewRatings.Refresh();
        }

        private void viewratings_Click(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.AvgRatings(vetID);
            ViewApp_ViewRatings.DataSource = dt;
            ViewApp_ViewRatings.Refresh();
        }

    }
}
