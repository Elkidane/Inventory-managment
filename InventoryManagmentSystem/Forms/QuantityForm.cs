using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagmentSystem.Forms
{
    public partial class QuantityForm : Form
    {
        public int Quantity { get; private set; }

        public QuantityForm()
        {
            InitializeComponent();
        }

       
        private void QuantityForm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            Quantity = Convert.ToInt32(txtQuantity.Text);

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }

}
