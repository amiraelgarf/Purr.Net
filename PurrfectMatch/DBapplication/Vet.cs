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

        }

        private void editdaysandtime_Click(object sender, EventArgs e)
        {

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
