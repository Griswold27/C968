using System;
using System.ComponentModel;

namespace InventoryManagementSystem
{
    class Product
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void AddAssociatedPart(Part part)
        {
            
        }

        public bool RemoveAssociatedPart(int num)
        {
            // default return
            return false;
        }

        public Part LookupAssociatedPart(int num)
        {
            // default return
            return AssociatedParts[num];
        }
    }
}