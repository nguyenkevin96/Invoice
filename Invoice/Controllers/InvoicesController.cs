using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Invoice.models;
using Invoice._services;
using Invoice.Repository;
using System.Threading.Tasks;
using System.Web.Http;

namespace Invoice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceRepository prodContext;

        public InvoicesController(IInvoiceRepository context)
        {
            prodContext = context;
        }

        // GET: api/Products
        [HttpGet("/api/Products")]
        public IEnumerable<Product> GetProduct()
        {

            return prodContext.GetAllProducts();
        }

        [HttpGet]
        [Route("/Products/{id}")]
        public Product ProductDetails(int id)
        {
            return prodContext.GetProduct(id);
        }

        [HttpGet("/api/Customers")]
        public IEnumerable<Customer> GetCustomer()
        {
            return prodContext.GetAllCustomers();
        }

        [HttpGet]
        [Route("/Customers/{id}")]
        public Customer CustomerDetails(int id)
        {
            return prodContext.GetCustomer(id);
        }
    }
}