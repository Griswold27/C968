using System;
using System.ComponentModel;
using System.Net.Http.Headers;



namespace InventoryManagementSystem
{
    public class Inventory
    {
        public BindingList<Product> Products { get; set; }
        public BindingList<Part> Parts { get; set; }

        public Inventory()
        {
            Parts = new BindingList<Part>();
            Products = new BindingList<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int id)
        {
            // default return
            return false;
        }

        public Product LookupProduct(int id)
        {
            // default return
            // return Products[id];

            foreach (Product product in Products)
            {
                if (product.ProductID == id)
                {
                    return product;
                }
            }

            return null;
        }

        public void UpdateProduct(int num, Product product)
        {

        }

        public void AddPart(Part part)
        {
            Parts.Add(part);
        }

        public bool DeletePart(Part part)
        {
            return Parts.Remove(part);
        }

        public bool DeleteProduct(Product product)
        {
            return Products.Remove(product);
        }

        public Part LookupPart(int num)
        {

            foreach (Part part in Parts)
            {
                if (part.PartID == num)
                {
                    return part;                    
                }
            }

            return null;
        }

        public void UpdatePart(int num, Part part)
        {
            int index = -1;

            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].PartID == num)
                {
                    Parts[i] = part;
                }
            }
        }
    }
}

