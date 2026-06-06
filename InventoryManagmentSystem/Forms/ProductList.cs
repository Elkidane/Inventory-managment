using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InventoryManagementSystem.Data;
using System.Linq;

namespace InventoryManagmentSystem.Forms
{
    public partial class ProductList : Form
    {
        public ProductList()
        {
            InitializeComponent();
        }


        private void RefreshProducts()
        {
            AppDbContext context = new AppDbContext();

            dgvProducts.DataSource = context.Products.ToList();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();

            form.ShowDialog();
            RefreshProducts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();

            string keyword = txtSearch.Text;

            var products = context.Products
                .Where(p => p.Name.Contains(keyword))
                .ToList();

            dgvProducts.DataSource = products;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int productId = Convert.ToInt32(
                        dgvProducts.SelectedRows[0]
                        .Cells["Id"].Value);

                    using (var context = new AppDbContext())
                    {
                        var product =
                            context.Products.Find(productId);

                        context.Products.Remove(product);

                        context.SaveChanges();
                    }

                    MessageBox.Show("Product Deleted");

                    RefreshProducts();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                ProductForm form = new ProductForm();

                form.ProductId = Convert.ToInt32(
                    dgvProducts.SelectedRows[0].Cells["Id"].Value);

                form.txtName.Text =
                    dgvProducts.SelectedRows[0].Cells["Name"].Value.ToString();

                form.txtCategory.Text =
                    dgvProducts.SelectedRows[0].Cells["Category"].Value.ToString();

                form.txtPrice.Text =
                    dgvProducts.SelectedRows[0].Cells["Price"].Value.ToString();

                form.txtSupplier.Text =
                    dgvProducts.SelectedRows[0].Cells["Supplier"].Value.ToString();

                form.numQuantity.Value =
                    Convert.ToInt32(
                        dgvProducts.SelectedRows[0].Cells["Quantity"].Value);

                form.ShowDialog();
                RefreshProducts();
            }
        }

        private void ProductList_Load(object sender, EventArgs e)
        {

            if (Session.CurrentUser.Role == "Staff")
            {
                btnDelete.Visible = false;


            }
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                int quantity = Convert.ToInt32(
                    row.Cells["Quantity"].Value);

                if (quantity < 5)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
