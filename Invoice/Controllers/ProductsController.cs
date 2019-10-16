using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Invoice.models;
using Invoice.Models;

namespace Invoice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        ProductDAO prodContext = new ProductDAO();

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