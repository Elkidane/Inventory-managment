using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Data;

namespace InventoryManagmentSystem.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        public int ProductId = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Product name is required",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show(
                    "Category is required",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtSupplier.Text))
            {
                MessageBox.Show(
                    "Supplier is required",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            decimal price;

            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show(
                    "Enter a valid price",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (price <= 0)
            {
                MessageBox.Show(
                    "Price must be greater than 0",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
                if (numQuantity.Value < 0)
            {
                MessageBox.Show(
                    "Quantity cannot be negative",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (AppDbContext context = new AppDbContext())
                {
                    // Check duplicate product
                    bool exists = context.Products.Any(p =>
                        p.Name == txtName.Text &&
                        p.Id != ProductId);

                    if (exists)
                    {
                        MessageBox.Show(
                            "Product already exists",
                            "Duplicate Product",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    Product product;

                    if (ProductId == 0)
                    {
                        product = new Product();

                        context.Products.Add(product);
                    }
                    else
                    {
                        product = context.Products.Find(ProductId);

                        if (product == null)
                        {
                            MessageBox.Show(
                                "Product not found");

                            return;
                        }
                    }

                    // Save data
                    product.Name = txtName.Text;
                    product.Category = txtCategory.Text;
                    product.Quantity = (int)numQuantity.Value;
                    product.Price = price;
                    product.Supplier = txtSupplier.Text;

                    context.SaveChanges();

                    MessageBox.Show(
                        "Product Saved Successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "System Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // Load existing product when editing

            if (ProductId != 0)
            {
                using (AppDbContext context = new AppDbContext())
                {
                    var product = context.Products.Find(ProductId);

                    if (product != null)
                    {
                        txtName.Text = product.Name;
                        txtCategory.Text = product.Category;
                        numQuantity.Value = product.Quantity;
                        txtPrice.Text = product.Price.ToString();
                        txtSupplier.Text = product.Supplier;
                    }
                }
            }
        }
    

private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
