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

        public PartForm(PartFormMode mode)
        {
            InitializeComponent();
            this.mode = mode;
            if (mode == PartFormMode.ModifyPart)
            {
                this.Text = "Modify Part";
                // Load the part data into the form fields for modification
            }
            else
            {
                this.Text = "Add Part";
                // Prepare the form for adding a new part
            }
        }

        public PartForm(Inventory inventory) : this() { mode = PartFormMode.AddPart; this.inventory = inventory; ConfigureMode(); } // ConfigureMode() is an arbitrary name.

        private void ConfigureMode()
        {
            throw new NotImplementedException();
        }
    }

    public enum PartFormMode { AddPart, ModifyPart }
    

   }
