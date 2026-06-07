namespace InventoryManagmentSystem.Forms
{
    partial class ProductForm
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
            txtName = new TextBox();
            txtCategory = new TextBox();
            numQuantity = new NumericUpDown();
            txtPrice = new TextBox();
            txtSupplier = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(601, 102);
            txtName.Margin = new Padding(4, 4, 4, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(194, 39);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(601, 187);
            txtCategory.Margin = new Padding(4, 4, 4, 4);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(194, 39);
            txtCategory.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(601, 265);
            numQuantity.Margin = new Padding(4, 4, 4, 4);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(222, 39);
            numQuantity.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(601, 340);
            txtPrice.Margin = new Padding(4, 4, 4, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(194, 39);
            txtPrice.TabIndex = 3;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(601, 428);
            txtSupplier.Margin = new Padding(4, 4, 4, 4);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(194, 39);
            txtSupplier.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DodgerBlue;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(579, 514);
            btnSave.Margin = new Padding(4, 4, 4, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(146, 72);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(478, 109);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(447, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 7;
            label2.Text = "Catagory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(450, 272);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 8;
            label3.Text = "Quantity";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(488, 347);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 9;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(468, 435);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 32);
            label5.TabIndex = 10;
            label5.Text = "Suplier";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.ForestGreen;
            label6.Location = new Point(81, 49);
            label6.Name = "label6";
            label6.Size = new Size(163, 32);
            label6.TabIndex = 11;
            label6.Text = "ADD AN ITEM";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 790);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtSupplier);
            Controls.Add(txtPrice);
            Controls.Add(numQuantity);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TextBox txtName;
        public TextBox txtCategory;
        public NumericUpDown numQuantity;
        public TextBox txtPrice;
        public TextBox txtSupplier;
        private Label label6;
    }
}