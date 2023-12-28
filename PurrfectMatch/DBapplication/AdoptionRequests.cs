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
    public partial class AdoptionRequests : Form
    {
        Controller controllerObj;
        string Username;
        public AdoptionRequests(string username)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Username = username;   
            pet_combo.Enabled = true;
            DataTable dt1 = controllerObj.SelectAllAdoptionRequests(Username);
            pet_combo.DisplayMember = "Name";
            pet_combo.ValueMember = "PetID";
            pet_combo.DataSource = dt1;

            pet_combo.SelectedIndexChanged += pet_combo_SelectedIndexChanged;
        }
        private void pet_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();


                //int selectedPetID = Convert.ToInt32(pet_combo.SelectedItem);
                DataRowView selectedRow = (DataRowView)pet_combo.SelectedItem;

                int selectedPetID = Convert.ToInt32(selectedRow["PetID"]);
                DataTable customerDataTable = controllerObj.GetCustomerInfoForpetadoption(selectedPetID);

                
                if (customerDataTable != null && customerDataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = customerDataTable;
                }
                else
                {   
                    MessageBox.Show("No data found for the selected pet.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int customerID = controllerObj.GetCustomerIDForpetadoption(Convert.ToInt32(pet_combo.SelectedValue));

            int r = controllerObj.AcceptAdoptionRequests(customerID, Convert.ToInt32(pet_combo.SelectedValue));
            if (r == 0)
            {
                MessageBox.Show("failed to accept");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int customerID = controllerObj.GetCustomerIDForpetadoption(Convert.ToInt32(pet_combo.SelectedValue));

            int r = controllerObj.DeclineAdoptionRequests(customerID, Convert.ToInt32(pet_combo.SelectedValue));
            if (r == 0)
            {
                MessageBox.Show("failed to accept");
            }
        }
    }
}
