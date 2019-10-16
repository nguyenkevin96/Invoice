using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Invoice.models;
using Invoice.Repository;

namespace Invoice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository prodContext;

        public ProductsController(IProductRepository context)
        {
            prodContext = context;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> GetProduct()
        {
            return prodContext.GetAllProducts();
        }

        [HttpGet("{id}")]
        public Product Details(int id)
        {
            return prodContext.GetProduct(id);
        }
    }
}