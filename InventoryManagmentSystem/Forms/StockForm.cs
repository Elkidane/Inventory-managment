using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagmentSystem.Forms
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();

            int productId = (int)cmbProducts.SelectedValue;

            var product = context.Products.Find(productId);

            int quantity = (int)numQuantity.Value;

            string type = cmbTransactionType.Text;

            if (type == "IN")
            {
                product.Quantity += quantity;
            }
            else if (type == "OUT")
            {
                if (product.Quantity < quantity)
                {
                    MessageBox.Show("Not enough stock!");

                    return;
                }

                product.Quantity -= quantity;
            }

            StockTransaction transaction = new StockTransaction();

            transaction.ProductId = productId;
            transaction.TransactionType = type;
            transaction.Quantity = quantity;
            transaction.TransactionDate = DateTime.Now;

            context.StockTransactions.Add(transaction);

            context.SaveChanges();

            MessageBox.Show("Stock Updated Successfully!");

            LoadTransactions();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StockForm_Load(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();

            cmbProducts.DataSource = context.Products.ToList();

            cmbProducts.DisplayMember = "Name";

            cmbProducts.ValueMember = "Id";

            LoadTransactions();
        }

        private void LoadTransactions()
        {
            AppDbContext context = new AppDbContext();

            dgvTransactions.DataSource = context.StockTransactions
                .Include(s => s.Product)
                .Select(s => new
                {
                    s.Id,
                    Product = s.Product.Name,
                    s.TransactionType,
                    s.Quantity,
                    s.TransactionDate
                })
                .ToList();
        }
    }
}
