using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagmentSystem.Forms
{
    public partial class StaffDashboard : Form
    {
        public string Username { get; private set; }

        public StaffDashboard()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductList products = new ProductList();
            products.Show();
        }
        private void LoadProducts()
        {
            using (var context = new AppDbContext())
            {
                dgvProducts.DataSource =
                    context.Products.ToList();
            }
        }
        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            lblTitle.Text =
    "Welcome " + Session.CurrentUser.Username;

            LoadProducts();

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {

            Session.CurrentUser = null;

            LoginForm login = new LoginForm();
            login.Show();

            this.Close();
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {

            if (dgvProducts.SelectedRows.Count > 0)
            {
                QuantityForm quantityForm =
                    new QuantityForm();

                if (quantityForm.ShowDialog()
                    == DialogResult.OK)
                {
                    int amount = quantityForm.Quantity;

                    int productId = Convert.ToInt32(
                        dgvProducts.SelectedRows[0]
                        .Cells["Id"].Value);

                    using (var context = new AppDbContext())
                    {
                        var product =
                            context.Products.Find(productId);

                        product.Quantity += amount;

                        Username = Session.CurrentUser.Username;

                        StockTransaction transaction =
                       new StockTransaction()
                       {
                       ProductId = product.Id,
                       Quantity = amount,
                      TransactionType = "IN",
                      TransactionDate = DateTime.Now,
                       Username = Session.CurrentUser.Username
                       };

                        context.StockTransactions.Add(transaction);

                        context.SaveChanges();
                    }

                    MessageBox.Show("Stock Added");

                    LoadProducts();
                }
            }
        }
        private void btnStockOut_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                QuantityForm quantityForm =
                    new QuantityForm();

                if (quantityForm.ShowDialog()
                    == DialogResult.OK)
                {
                    int amount = quantityForm.Quantity;

                    int productId = Convert.ToInt32(
                        dgvProducts.SelectedRows[0]
                        .Cells["Id"].Value);

                    using (var context = new AppDbContext())
                    {
                        var product =
                            context.Products.Find(productId);

                        product.Quantity -= amount;


                        StockTransaction transaction =
    new StockTransaction()
    {
        ProductId = product.Id,
        Quantity = amount,
        TransactionType = "OUT",
        TransactionDate = DateTime.Now,
        Username = Session.CurrentUser.Username
    };

                        context.StockTransactions.Add(transaction);


                        context.SaveChanges();

                        product.Quantity -= amount;

                        context.SaveChanges();

                        if (product.Quantity < 5)
                        {
                            MessageBox.Show(
                                product.Name + " stock is low!",
                                "Low Stock Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }

                    MessageBox.Show("Stock Removed successfuly");

                    LoadProducts();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockForm form = new StockForm();

            form.ShowDialog();
        }
    }
}
