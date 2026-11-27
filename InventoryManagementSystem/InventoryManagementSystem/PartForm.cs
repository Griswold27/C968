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
    public partial class PartForm : Form
    {
        private PartFormMode mode;
        public Inventory inventory;
        private Part editingPart;
        public PartForm()
        {
            InitializeComponent();

            
        }

        //public PartForm(PartFormMode mode)
        //{
        //    InitializeComponent();
        //    this.mode = mode;
        //    if (mode == PartFormMode.ModifyPart)
        //    {
        //        this.Text = "Modify Part";
        //        // Load the part data into the form fields for modification
        //    }
        //    else
        //    {
        //        this.Text = "Add Part";
        //        // Prepare the form for adding a new part
        //    }
        //}

        //public PartForm(Inventory inventory) : this() { mode = PartFormMode.AddPart; this.inventory = inventory; ConfigureMode(); } 

        public PartForm(Inventory inventory, PartFormMode formMode = PartFormMode.AddPart, Part partToEdit = null) : this()
        {
            this.mode = formMode;
            this.inventory = inventory;
            this.editingPart = partToEdit;
            ConfigureMode();
        }

        private void ConfigureMode()
        {
            // throw new NotImplementedException();
            if (mode == PartFormMode.AddPart)
            {
                ConfigureAddMode();
            }
            else if (mode == PartFormMode.ModifyPart)
            {
                ConfigureModifyMode();
            }
        }

        private void ConfigureAddMode()
        {
            // Part newPart = new Part();
            this.Text = "Add Part";
            radioInHouse.Checked = true;
            btnSave.Text = "Add";
            lblTitle.Text = "Add Part";
        }

        private void ConfigureModifyMode()
        {
            this.Text = "Modify Part";
            btnSave.Text = "Update";
            lblTitle.Text = "Modify Part";

            // Populate fields
            PopulateForm(editingPart);
        }

        private void PopulateForm(Part part)
        {
            if (part is Inhouse)
            {
                radioOutsourced.Checked = true;
            }
            else
            {
                radioInHouse.Checked = true;
            }
            txtPartID.Text = part.PartID.ToString();
            txtPartName.Text = part.Name;
            txtPrice.Text = part.Price.ToString();
            txtInventory.Text = part.InStock.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Part part;

            if (radioInHouse.Checked)
            {
                Inhouse inhouse = new Inhouse();
                inhouse.MachineID = int.Parse(txtMachineID.Text);
                part = inhouse;
            }
            else
            {
                Outsourced outsourced = new Outsourced();
                outsourced.CompanyName = txtMachineID.Text;
                part = outsourced;
            }

            part.Name = txtPartName.Text;
            part.PartID = int.Parse(txtPartID.Text);
            //part.IsOutsourced = radioOutsourced.Checked;
            part.Price = decimal.Parse(txtPrice.Text);
            part.InStock = int.Parse(txtInventory.Text);
            part.Max = int.Parse(txtMax.Text);
            part.Min = int.Parse(txtMin.Text);


            if (mode == PartFormMode.AddPart)
            {
                inventory.AddPart(part);
            }
            else if (mode == PartFormMode.ModifyPart)
            {
                inventory.UpdatePart(part.PartID, part);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineCompany.Text = "Company Name";
        }

        private void radioInHouse_CheckedChanged(object sender, EventArgs e)
        {
            lblMachineCompany.Text = "Machine ID";
        }
    }

    public enum PartFormMode { AddPart, ModifyPart }
    

   }
