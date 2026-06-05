namespace InventoryManagmentSystem.Forms
{
    partial class QuantityForm
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
            lblTitle = new Label();
            txtQuantity = new TextBox();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.ForeColor = Color.ForestGreen;
            lblTitle.Location = new Point(21, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Enter Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 12F);
            txtQuantity.Location = new Point(146, 186);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 46);
            txtQuantity.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirm.Font = new Font("Segoe UI", 12F);
            btnConfirm.Location = new Point(166, 271);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(112, 71);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click_1;
            // 
            // QuantityForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 485);
            Controls.Add(btnConfirm);
            Controls.Add(txtQuantity);
            Controls.Add(lblTitle);
            Name = "QuantityForm";
            Text = "QuantityForm";
            Load += QuantityForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtQuantity;
        private Button btnConfirm;
    }
}