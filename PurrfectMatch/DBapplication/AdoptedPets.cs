using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DBapplication
{
    public partial class AdoptedPets : Form
    {
        Controller controllerObj;
        public AdoptedPets()
        {

            InitializeComponent();
            controllerObj = new Controller();
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> adoptionData = controllerObj.GetAdoptionPercentageByType();
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Titles.Add("Adoption Percentage");
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "AdoptionPercentage",
                IsVisibleInLegend = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            foreach (var kvp in adoptionData)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }
            chart1.Series.Add(series);
        }
    }
}
