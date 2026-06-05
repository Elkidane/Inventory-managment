using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagmentSystem.Forms
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Staff");

            cmbRole.SelectedIndex = 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
    txtUsername.Text))
            {
                MessageBox.Show(
                    "Username required");

                return;
            }

            if (string.IsNullOrWhiteSpace(
                txtPassword.Text))
            {
                MessageBox.Show(
                    "Password required");

                return;
            }

            try
            {
                using (var context =
                    new AppDbContext())
                {
                    bool exists = context.Users
                        .Any(u =>
                            u.Username ==
                            txtUsername.Text);

                    if (exists)
                    {
                        MessageBox.Show(
                            "Username already exists");

                        return;
                    }

                    User user = new User();

                    user.Username =
                        txtUsername.Text;

                    user.Password =
                        txtPassword.Text;

                    user.Role =
                        cmbRole.Text;

                    user.IsActive = true;

                    context.Users.Add(user);

                    context.SaveChanges();

                    MessageBox.Show(
                        "User Added Successfully");

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
