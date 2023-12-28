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
    public partial class ManagerStatistics : Form
    {
        Controller controllerObj;
        string ID;
        public ManagerStatistics(string managerID)
        {
            InitializeComponent();
            controllerObj = new Controller();
            ID = managerID;
        }

        private void ManagerStatistics_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please, insert the values of the least seeling products you wanna view");

            }
            else
            {
                string numberofleastSellingItems=textBox1.Text;
                bool yes = int.TryParse(numberofleastSellingItems, out _);
                if (yes)
                {
                    string bestSellingItem = controllerObj.GetBestSellingItemLastMonth();
                    var leastSellingItems = controllerObj.GetLeastSellingItemsLastMonth(Convert.ToInt32(textBox1.Text));
                    label1.Visible = !label1.Visible;
                    DisplayStatistics(bestSellingItem, leastSellingItems);
                    DisplayStatisticsChart(bestSellingItem, leastSellingItems);


                }
                else
                {
                    MessageBox.Show("Please, an integer");
                }
                

            }

        }

        private void DisplayStatistics(string bestSellingItem, List<string> leastSellingItems)
        {
            // Update UI
            label1.Text = $"Best Selling Item Last Month: {bestSellingItem}\n" +
                                $"Least Selling Items Last Month: {string.Join(", ", leastSellingItems)}";
        }

        private void DisplayStatisticsChart(string bestSellingItem, List<string> leastSellingItems)
        {
            chart1.Series.Clear();

            // Add a series for best-selling item
            Series bestSellingSeries = new Series("Best Selling Item");
            bestSellingSeries.Points.AddXY(bestSellingItem, controllerObj.GetProductQuantity(bestSellingItem));
            bestSellingSeries.ChartType = SeriesChartType.Bar;

            // Add a series for least selling items
            Series leastSellingSeries = new Series("Least Selling Items");
            foreach (var item in leastSellingItems)
            {
                leastSellingSeries.Points.AddXY(item, controllerObj.GetProductQuantity(item));
            }
            leastSellingSeries.ChartType = SeriesChartType.Bar;

            // Add the series to the chart
            chart1.Series.Add(bestSellingSeries);
            chart1.Series.Add(leastSellingSeries);

            // Set chart title and axis labels
            chart1.Titles.Clear();
            chart1.Titles.Add("Sales Statistics");
            chart1.ChartAreas[0].AxisX.Title = "Product";
            chart1.ChartAreas[0].AxisY.Title = "Quantity";

            chart1.Refresh();
        }

    }
}
