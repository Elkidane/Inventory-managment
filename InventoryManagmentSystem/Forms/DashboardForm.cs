using InventoryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace InventoryManagmentSystem.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductList form = new ProductList();
            form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tnStock_Click(object sender, EventArgs e)
        {
            StockForm form = new StockForm();

            form.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void DashboardForm_Load(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();

            int totalProducts = context.Products.Count();

            int lowStock = context.Products
                .Count(p => p.Quantity < 5);

            decimal inventoryValue = context.Products
                .Sum(p => p.Price * p.Quantity);

            int totalTransactions = context.StockTransactions.Count();

            lblTotalProducts.Text =
                "Total Products: " + totalProducts;

            lblLowStock.Text =
                "Low Stock Products: " + lowStock;

            lblInventoryValue.Text =
                "Inventory Value: " + inventoryValue + "ETB";

            lblTransactions.Text =
                "Total Transactions: " + totalTransactions;

            chartTransactions.Series.Clear();
            chartTransactions.ChartAreas.Clear();

            ChartArea area = new ChartArea();

            chartTransactions.ChartAreas.Add(area);

            Series series = new Series("Transactions");

            series.ChartType = SeriesChartType.Column;



            DateTime today = DateTime.Today;

            // Add all 7 days manually
            for (int i = 6; i >= 0; i--)
            {
                DateTime currentDay = today.AddDays(-i);

                int transactionCount = context.StockTransactions
     .Where(t =>
         t.TransactionDate >= currentDay &&
         t.TransactionDate < currentDay.AddDays(1))
     .Count();

                DataPoint point = new DataPoint();

                point.AxisLabel = currentDay.ToString("ddd");

                point.YValues = new double[] { transactionCount };

                series.Points.Add(point);
            }
            timerRefresh.Start();
            chartTransactions.Series.Add(series);
            CheckLowStock();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();

            form.ShowDialog();
        }

        private void lblAlert_Click(object sender, EventArgs e)
        {

        }

        private void CheckLowStock()
        {
            using (var context = new AppDbContext())
            {
                var lowStockProducts = context.Products
                    .Where(p => p.Quantity < 5)
                    .ToList();

                lblLowStock.Text =
                    "Low Stock Products: " +
                    lowStockProducts.Count;

                if (lowStockProducts.Count > 0)
                {
                    string message = "";

                    foreach (var product in lowStockProducts)
                    {
                        message +=
                            "⚠ " + product.Name +
                            " only has " +
                            product.Quantity +
                            " left\n";
                    }

                    lblAlert.Text = message;
                }
                else
                {
                    lblAlert.Text =
                        "All products sufficiently stocked";
                }
            }
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {

            CheckLowStock();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserManagement form =
    new UserManagement();

            form.ShowDialog();
        }

        private void chartTransactions_Click(object sender, EventArgs e)
        {

        }
    }
}
