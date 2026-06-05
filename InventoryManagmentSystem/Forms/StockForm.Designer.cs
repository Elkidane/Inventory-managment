namespace InventoryManagmentSystem.Forms
{
    partial class StockForm
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
            cmbProducts = new ComboBox();
            cmbTransactionType = new ComboBox();
            numQuantity = new NumericUpDown();
            btnSave = new Button();
            dgvTransactions = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            SuspendLayout();
            // 
            // cmbProducts
            // 
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(129, 622);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(227, 33);
            cmbProducts.TabIndex = 0;
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Items.AddRange(new object[] { "IN", "OUT" });
            cmbTransactionType.Location = new Point(641, 622);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(182, 33);
            cmbTransactionType.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(1057, 622);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(199, 31);
            numQuantity.TabIndex = 2;
            numQuantity.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11F);
            btnSave.Location = new Point(656, 684);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button1_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(120, 92);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersWidth = 62;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.Size = new Size(1132, 476);
            dgvTransactions.TabIndex = 4;
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(129, 589);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 5;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(641, 589);
            label2.Name = "label2";
            label2.Size = new Size(174, 30);
            label2.TabIndex = 6;
            label2.Text = "Transaction Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(1057, 589);
            label3.Name = "label3";
            label3.Size = new Size(95, 30);
            label3.TabIndex = 7;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(0, 192, 192);
            label4.Location = new Point(606, 35);
            label4.Name = "label4";
            label4.Size = new Size(253, 38);
            label4.TabIndex = 8;
            label4.Text = "Transaction History";
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 737);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTransactions);
            Controls.Add(btnSave);
            Controls.Add(numQuantity);
            Controls.Add(cmbTransactionType);
            Controls.Add(cmbProducts);
            Name = "StockForm";
            Text = "StockForm";
            Load += StockForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProducts;
        private ComboBox cmbTransactionType;
        private NumericUpDown numQuantity;
        private Button btnSave;
        private DataGridView dgvTransactions;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}