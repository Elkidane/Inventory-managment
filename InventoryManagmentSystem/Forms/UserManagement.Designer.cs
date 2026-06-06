namespace InventoryManagmentSystem.Forms
{
    partial class UserManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvUsers = new DataGridView();
            btnAdd = new Button();
            btnBlock = new Button();
            btnActivate = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(146, 69);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersWidth = 62;
            dgvUsers.Size = new Size(1054, 494);
            dgvUsers.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(1073, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Staff";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBlock
            // 
            btnBlock.BackColor = Color.FromArgb(192, 0, 0);
            btnBlock.Font = new Font("Segoe UI", 12F);
            btnBlock.Location = new Point(868, 565);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(127, 43);
            btnBlock.TabIndex = 2;
            btnBlock.Text = "Block";
            btnBlock.UseVisualStyleBackColor = false;
            btnBlock.Click += btnBlock_Click;
            // 
            // btnActivate
            // 
            btnActivate.BackColor = Color.FromArgb(0, 192, 192);
            btnActivate.Font = new Font("Segoe UI", 12F);
            btnActivate.Location = new Point(1032, 565);
            btnActivate.Name = "btnActivate";
            btnActivate.Size = new Size(127, 43);
            btnActivate.TabIndex = 3;
            btnActivate.Text = "UnBlock";
            btnActivate.UseVisualStyleBackColor = false;
            btnActivate.Click += btnActivate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(198, 32);
            label1.TabIndex = 4;
            label1.Text = "User Managment";
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 620);
            Controls.Add(label1);
            Controls.Add(btnActivate);
            Controls.Add(btnBlock);
            Controls.Add(btnAdd);
            Controls.Add(dgvUsers);
            Name = "UserManagement";
            Text = "UserManagement";
            Load += UserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnAdd;
        private Button btnBlock;
        private Button btnActivate;
        private Label label1;
    }
}