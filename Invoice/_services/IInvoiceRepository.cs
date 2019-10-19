using Invoice.models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Invoice._services
{
    public interface IInvoiceRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Customer> GetAllCustomers();
        Product GetProduct(int id);
        Customer GetCustomer(int id);
    }
}
