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
        private Inventory inventory;
        private Product currentProduct;

        // Add Mode
        public ProductForm(Inventory inventory, ProductFormMode mode)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.mode = mode;
            this.Text = (mode == ProductFormMode.AddProduct) ? "Add Product" : "Modify Product";

            InitializeGrids();
            if (mode == ProductFormMode.AddProduct)
            {
                currentProduct = new Product { AssociatedParts = new BindingList<Part>() };
            }
        }

        // Modify Mode
        public ProductForm(Inventory inventory, ProductFormMode mode, Product productToModify) : this(inventory, mode)
        {
            currentProduct = productToModify;
            LoadProductData();
            RefreshGrids();
        }

        private void InitializeGrids()
        {
            // Associated Parts
            dataGridAssociatedParts.DataSource = null;
            dataGridAssociatedParts.AutoGenerateColumns = true;
        }

        //public ProductForm(ProductFormMode mode)
        //{
        //    InitializeComponent();
        //    this.mode = mode;
        //    if (mode == ProductFormMode.ModifyProduct)
        //    {
        //        this.Text = "Modify Product";
        //    }
        //    else
        //    {
        //        this.Text = "Add Product";
        //    }
        //}

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public enum ProductFormMode { AddProduct, ModifyProduct }
}
