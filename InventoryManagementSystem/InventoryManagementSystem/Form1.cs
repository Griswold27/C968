using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        private Inventory inventory;
        public Form1()
        {
            InitializeComponent();

           inventory = new Inventory();
           dataGridParts.DataSource = inventory.Parts;
        }

        private void RefreshPartsGrid()
        {
            dataGridParts.DataSource = null;
            dataGridParts.DataSource = inventory.Parts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnPartsAdd_Click(object sender, EventArgs e)
        {

            using (PartForm partForm = new PartForm(this.inventory, PartFormMode.AddPart))
            {
                if (partForm.ShowDialog(this) == DialogResult.OK)
                {
                    RefreshPartsGrid();
                }
            }
        }

        private void btnPartsModify_Click(object sender, EventArgs e)
        {
            using (PartForm partForm = new PartForm(this.inventory, PartFormMode.ModifyPart))
            {
                partForm.ShowDialog(this);
            }
        }

        private void btnProductsAdd_Click(object sender, EventArgs e)
        {
            using (ProductForm productForm = new ProductForm(ProductFormMode.AddProduct))
            {
                productForm.ShowDialog(this);
            }
        }

        private void dataGridPartsCell_Click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProductsModify_Click(object sender, EventArgs e)
        {
            using (ProductForm productForm = new ProductForm(ProductFormMode.ModifyProduct))
            {
                productForm.ShowDialog(this);
            }
        }

        private void btnPartsDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridParts.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Value is null. Select a valid part to delete");
                return;
            }

            int partID = (int)selectedRow.Cells[0].Value;

            Part part = inventory.LookupPart(partID);

            inventory.DeletePart(part);
        }

        private void btnProductsDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridProducts.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Value is null. Select a valid product to delete");
                return;
            }

            int productID = (int)selectedRow.Cells[0].Value;

            Product product = inventory.LookupProduct(productID);

            inventory.DeleteProduct(product);
        }

        private void btnSearchPart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPartsSearch.Text, out int partID))
            {
                dataGridParts.DataSource = inventory.Parts;
                MessageBox.Show("Please enter a valid search Term");
                return;
            }

            Part part = inventory.LookupPart(partID);

            if (part == null)
            {
                MessageBox.Show($"No part found with ID {partID}.");
                dataGridParts.DataSource = inventory.Parts;
                return;
            }

            // Bind grid to match list
            dataGridParts.DataSource = new List<Part> { part };

            //var matchingParts = inventory.Parts.Where(part => part.PartID == partID).ToList();

            //dataGridParts.DataSource = matchingParts;

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductsSearch.Text, out int productID))
            {
                dataGridProducts.DataSource = inventory.Products;
                MessageBox.Show("Please enter a valid search Term");
                return;
            }

            Product product = inventory.LookupProduct(productID);

            if (product == null)
            {
                MessageBox.Show($"No product found with ID {productID}.");
                dataGridProducts.DataSource = inventory.Products;
                return;
            }

            // Bind grid to match list
            dataGridProducts.DataSource = new List<Product> { product };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
