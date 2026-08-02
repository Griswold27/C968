using System;
using System.ComponentModel;
using System.Net.Http.Headers;



namespace InventoryManagementSystem
{
    class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> AllParts { get; set; }

        public void addProduct(Product product)
        {

        }

        public bool RemoveProduct(int id)
        {
            // default return
            return false;
        }

        public Product LookupProduct(int id)
        {
            // default return
            return Products[id];
        }

        public void updateProduct(int num, Product product)
        {

        }

        public void addPart(Part part)
        {

        }

        public bool deletePart(Part part)
        {
            // default return
            return false;
        }

        public Part LookupPart(int num)
        {
            // default return
            return AllParts[num];
        }

        public void UpdatePart(int num, Part part)
        {

        }
    }
}

