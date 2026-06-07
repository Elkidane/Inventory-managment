using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventoryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InventoryManagmentSystem.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();

            string reportType = cmbReportType.Text;

            if (reportType == "Inventory Report")
            {
                dgvReports.DataSource = context.Products.ToList();
            }

            else if (reportType == "Low Stock Report")
            {
                dgvReports.DataSource = context.Products
                    .Where(p => p.Quantity < 5)
                    .ToList();
            }

            else if (reportType == "Transaction Report")
            {
                dgvReports.DataSource = context.StockTransactions
                    .Include(s => s.Product)
                    .Select(s => new
                    {
                        Product = s.Product.Name,
                        s.TransactionType,
                        s.Quantity,
                        s.TransactionDate
                    })
                    .ToList();
            }

        }

        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
