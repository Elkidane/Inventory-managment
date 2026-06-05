namespace InventoryManagmentSystem.Forms
{
    partial class AddUser
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 0;
            label1.Text = "Add User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(215, 116);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(215, 228);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(215, 341);
            label4.Name = "label4";
            label4.Size = new Size(60, 32);
            label4.TabIndex = 3;
            label4.Text = "Role";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(262, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 39);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(262, 263);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 39);
            txtPassword.TabIndex = 5;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(262, 385);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(150, 33);
            cmbRole.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(253, 493);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 49);
            btnSave.TabIndex = 7;
            btnSave.Text = " Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 586);
            Controls.Add(btnSave);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddUser";
            Text = "AddUser";
            Load += AddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbRole;
        private Button btnSave;
    }
}