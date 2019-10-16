using Invoice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Models
{
    public class ProductDAO
    {
        InvoiceContext _context = new InvoiceContext();

        //Returns a list of all products
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                return _context.Product.ToList();
            }
            catch
            {
                throw;
            }
        }

        //Finds the product id and displays the products information
        public Product GetProduct(int id)
        {
            try
            {
                Product prod = _context.Product.Find(id);
                return prod;
            }
            catch
            {
                throw;
            }
        }
    }
}
