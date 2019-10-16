using Invoice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invoice.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly InvoiceContext _context;

        public ProductRepository(InvoiceContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Product;
        }

        public Product GetProduct(int id)
        {
            Product prod = _context.Product.Find(id);
            return prod;
        }
    }
}
