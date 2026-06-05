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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validation

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show(
                    "Username is required",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Password is required",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (AppDbContext context =
                    new AppDbContext())
                {
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    var user = context.Users
                        .FirstOrDefault(u =>
                            u.Username == username &&
                            u.Password == password);

                    // User not found
                    if (user == null)
                    {
                        MessageBox.Show(
                            "Invalid username or password",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // Blocked account
                    if (user.IsActive == false)
                    {
                        MessageBox.Show(
                            "Your account has been blocked",
                            "Access Denied",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    Session.CurrentUser = user;

                    MessageBox.Show(
                        "Login Successful!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Admin
                    if (user.Role == "Admin")
                    {
                        DashboardForm admin =
                            new DashboardForm();

                        admin.Show();
                    }

                    // Staff
                    else if (user.Role == "Staff")
                    {
                        StaffDashboard staff =
                            new StaffDashboard();

                        staff.Show();
                    }

                    this.Hide();
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
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
