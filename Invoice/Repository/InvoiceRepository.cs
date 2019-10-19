using Invoice.models;
using System.Collections.Generic;
using Invoice._services;

namespace Invoice.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly InvoiceContext _context;

        public InvoiceRepository(InvoiceContext context)
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

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customer;
        }

        public Customer GetCustomer(int id)
        {
            Customer customer = _context.Customer.Find(id);
            return customer;
        }
    }
}
