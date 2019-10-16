using System;
using System.Collections.Generic;

namespace Invoice.models
{
    public partial class Product
    {
        public Product()
        {
            Item = new HashSet<Item>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public ICollection<Item> Item { get; set; }
    }
}
