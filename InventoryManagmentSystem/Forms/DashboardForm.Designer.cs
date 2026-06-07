namespace InventoryManagmentSystem.Forms
{
    partial class DashboardForm
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnProducts = new Button();
            btnReports = new Button();
            btnLogout = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnStock = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            lblLowStock = new Label();
            lblInventoryValue = new Label();
            lblTransactions = new Label();
            lblTotalProducts = new Label();
            groupBox2 = new GroupBox();
            chartTransactions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblAlert = new Label();
            timerRefresh = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTransactions).BeginInit();
            SuspendLayout();
            // 
            // btnProducts
            // 
            btnProducts.Font = new Font("Segoe UI", 12F);
            btnProducts.ForeColor = SystemColors.ControlText;
            btnProducts.Location = new Point(20, 53);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(210, 80);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "Manage Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += button1_Click;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 12F);
            btnReports.ForeColor = SystemColors.Desktop;
            btnReports.Location = new Point(21, 428);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(190, 79);
            btnReports.TabIndex = 1;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Firebrick;
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.Location = new Point(1095, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(148, 56);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += button3_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnStock
            // 
            btnStock.Font = new Font("Segoe UI", 12F);
            btnStock.ForeColor = SystemColors.ControlText;
            btnStock.Location = new Point(14, 176);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(216, 80);
            btnStock.TabIndex = 4;
            btnStock.Text = "Stock Managment";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += tnStock_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(258, 41);
            label1.TabIndex = 5;
            label1.Text = "Admin Dashboard";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnProducts);
            groupBox1.Controls.Add(btnStock);
            groupBox1.Controls.Add(btnReports);
            groupBox1.Location = new Point(12, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 533);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(14, 294);
            button1.Name = "button1";
            button1.Size = new Size(216, 80);
            button1.TabIndex = 5;
            button1.Text = "User Managment";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Segoe UI", 14F);
            lblLowStock.ForeColor = SystemColors.ActiveCaptionText;
            lblLowStock.Location = new Point(6, 150);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(262, 38);
            lblLowStock.TabIndex = 7;
            lblLowStock.Text = "Low Stock Products:";
            // 
            // lblInventoryValue
            // 
            lblInventoryValue.AutoSize = true;
            lblInventoryValue.Font = new Font("Segoe UI", 14F);
            lblInventoryValue.ForeColor = SystemColors.ActiveCaptionText;
            lblInventoryValue.Location = new Point(435, 56);
            lblInventoryValue.Name = "lblInventoryValue";
            lblInventoryValue.Size = new Size(214, 38);
            lblInventoryValue.TabIndex = 8;
            lblInventoryValue.Text = "Inventory Value:";
            // 
            // lblTransactions
            // 
            lblTransactions.AutoSize = true;
            lblTransactions.Font = new Font("Segoe UI", 14F);
            lblTransactions.ForeColor = SystemColors.ActiveCaptionText;
            lblTransactions.Location = new Point(435, 150);
            lblTransactions.Name = "lblTransactions";
            lblTransactions.Size = new Size(241, 38);
            lblTransactions.TabIndex = 9;
            lblTransactions.Text = "Total Transactions:";
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("Segoe UI", 14F);
            lblTotalProducts.ForeColor = SystemColors.ActiveCaptionText;
            lblTotalProducts.Location = new Point(6, 56);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(205, 38);
            lblTotalProducts.TabIndex = 10;
            lblTotalProducts.Text = " Total Products:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.InactiveBorder;
            groupBox2.Controls.Add(lblTotalProducts);
            groupBox2.Controls.Add(lblLowStock);
            groupBox2.Controls.Add(lblTransactions);
            groupBox2.Controls.Add(lblInventoryValue);
            groupBox2.Location = new Point(276, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(967, 241);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // chartTransactions
            // 
            chartArea1.Name = "ChartArea1";
            chartTransactions.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTransactions.Legends.Add(legend1);
            chartTransactions.Location = new Point(276, 352);
            chartTransactions.Name = "chartTransactions";
            chartTransactions.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTransactions.Series.Add(series1);
            chartTransactions.Size = new Size(967, 426);
            chartTransactions.TabIndex = 12;
            chartTransactions.Text = "chart1";
            chartTransactions.Click += chartTransactions_Click;
            // 
            // lblAlert
            // 
            lblAlert.AutoSize = true;
            lblAlert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlert.ForeColor = Color.FromArgb(192, 0, 0);
            lblAlert.Location = new Point(357, 30);
            lblAlert.Name = "lblAlert";
            lblAlert.Size = new Size(83, 32);
            lblAlert.TabIndex = 13;
            lblAlert.Text = "label2";
            lblAlert.Click += lblAlert_Click;
            // 
            // timerRefresh
            // 
            timerRefresh.Enabled = true;
            timerRefresh.Interval = 3000;
            timerRefresh.Tick += timerRefresh_Tick;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 815);
            Controls.Add(lblAlert);
            Controls.Add(chartTransactions);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProducts;
        private Button btnReports;
        private Button btnLogout;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnStock;
        private Label label1;
        private GroupBox groupBox1;
        private Label lblLowStock;
        private Label lblInventoryValue;
        private Label lblTransactions;
        private Label lblTotalProducts;
        private GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTransactions;
        private Label lblAlert;
        private System.Windows.Forms.Timer timerRefresh;
        private Button button1;
    }
}