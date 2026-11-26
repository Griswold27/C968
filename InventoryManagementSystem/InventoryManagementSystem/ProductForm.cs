using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ProductForm : Form
    {
        private ProductFormMode mode;
        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(ProductFormMode mode)
        {
            InitializeComponent();
            this.mode = mode;
            if (mode == ProductFormMode.ModifyProduct)
            {
                this.Text = "Modify Product";
            }
            else
            {
                this.Text = "Add Product";
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public enum ProductFormMode { AddProduct, ModifyProduct }
}
