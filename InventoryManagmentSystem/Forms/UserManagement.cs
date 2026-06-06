using InventoryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagmentSystem.Forms
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void LoadUsers()
        {
            using (var context = new AppDbContext())
            {
                dgvUsers.DataSource = context.Users
                    .Select(u => new
                    {
                        u.Id,
                        u.Username,
                        u.Role,
                        Status = u.IsActive ? "Active" : "Blocked"
                    })
                    .ToList();
            }
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
            dgvUsers.Columns[0].Visible = false;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DialogResult result =
                    MessageBox.Show(
                        "Block this user?",
                        "Confirm Block",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int userId =
                            Convert.ToInt32(
                                dgvUsers.SelectedRows[0]
                                .Cells[0].Value);

                        using (var context =
                            new AppDbContext())
                        {
                            var user =
                                context.Users.Find(userId);

                            if (user.Username ==
    Session.CurrentUser.Username)
                            {
                                MessageBox.Show(
                                    "You cannot block yourself");

                                return;
                            }

                            if (user != null)
                            {
                                user.IsActive = false;

                                context.SaveChanges();

                                MessageBox.Show(
                                    "User Blocked");

                                LoadUsers();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DialogResult result =
                    MessageBox.Show(
                        "UnBlock this user?",
                        "Confirm UnBlock",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int userId =
                            Convert.ToInt32(
                                dgvUsers.SelectedRows[0]
                                .Cells[0].Value);

                        using (var context =
                            new AppDbContext())
                        {
                            var user =
                                context.Users.Find(userId);

                            if (user != null)
                            {
                                user.IsActive = true;

                                context.SaveChanges();

                                MessageBox.Show(
                                    "User UnBlocked");

                                LoadUsers();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser form =new AddUser();

            form.ShowDialog();

            LoadUsers();
        }
    }
}
