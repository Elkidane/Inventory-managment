namespace InventoryManagmentSystem.Forms
{
    partial class StaffDashboard
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
            label = new Label();
            lblTitle = new Label();
            btnProducts = new Button();
            btnStockIn = new Button();
            btnStockOut = new Button();
            btnLogout = new Button();
            dgvProducts = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 12F);
            label.Location = new Point(503, 23);
            label.Name = "label";
            label.Size = new Size(348, 32);
            label.TabIndex = 0;
            label.Text = "Inventory Management System";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.ForeColor = Color.FromArgb(0, 192, 192);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(222, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "STAFF DASHBOARD";
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 11F);
            btnProducts.Location = new Point(40, 106);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(194, 60);
            btnProducts.TabIndex = 2;
            btnProducts.Text = "Manage Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnStockIn
            // 
            btnStockIn.Font = new Font("Segoe UI", 12F);
            btnStockIn.Location = new Point(40, 202);
            btnStockIn.Name = "btnStockIn";
            btnStockIn.Size = new Size(194, 41);
            btnStockIn.TabIndex = 3;
            btnStockIn.Text = "Stock IN";
            btnStockIn.UseVisualStyleBackColor = true;
            btnStockIn.Click += btnStockIn_Click;
            // 
            // btnStockOut
            // 
            btnStockOut.Font = new Font("Segoe UI", 12F);
            btnStockOut.Location = new Point(40, 282);
            btnStockOut.Name = "btnStockOut";
            btnStockOut.Size = new Size(194, 46);
            btnStockOut.TabIndex = 4;
            btnStockOut.Text = "Stock OUT";
            btnStockOut.UseVisualStyleBackColor = true;
            btnStockOut.Click += btnStockOut_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(192, 0, 0);
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.Location = new Point(96, 470);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 47);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(285, 86);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 62;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(890, 386);
            dgvProducts.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(40, 369);
            button1.Name = "button1";
            button1.Size = new Size(210, 51);
            button1.TabIndex = 7;
            button1.Text = "Stock Transaction";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 519);
            Controls.Add(button1);
            Controls.Add(dgvProducts);
            Controls.Add(btnLogout);
            Controls.Add(btnStockOut);
            Controls.Add(btnStockIn);
            Controls.Add(btnProducts);
            Controls.Add(lblTitle);
            Controls.Add(label);
            Name = "StaffDashboard";
            Text = "StaffDashboard";
            Load += StaffDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label2;
        private Button btnProducts;
        private Button btnStockIn;
        private Button btnStockOut;
        private Button btnLogout;
        private DataGridView dgvProducts;
        private Label label;
        private Button button1;
    }
}