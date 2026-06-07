namespace InventoryManagmentSystem.Forms
{
    partial class ReportForm
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
            label1 = new Label();
            cmbReportType = new ComboBox();
            btnGenerate = new Button();
            dgvReports = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(167, 38);
            label1.TabIndex = 0;
            label1.Text = "Report Page";
            // 
            // cmbReportType
            // 
            cmbReportType.Font = new Font("Segoe UI", 10F);
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Inventory Report", "Low Stock Report", "Transaction Report" });
            cmbReportType.Location = new Point(318, 97);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(271, 36);
            cmbReportType.TabIndex = 1;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(0, 192, 192);
            btnGenerate.Font = new Font("Segoe UI", 12F);
            btnGenerate.Location = new Point(906, 88);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(131, 50);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // dgvReports
            // 
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(12, 157);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 62;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(1042, 533);
            dgvReports.TabIndex = 3;
            dgvReports.CellContentClick += dgvReports_CellContentClick;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 717);
            Controls.Add(dgvReports);
            Controls.Add(btnGenerate);
            Controls.Add(cmbReportType);
            Controls.Add(label1);
            Name = "ReportForm";
            Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbReportType;
        private Button btnGenerate;
        private DataGridView dgvReports;
    }
}