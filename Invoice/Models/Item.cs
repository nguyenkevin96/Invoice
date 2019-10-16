using System;
using System.Collections.Generic;

namespace Invoice.models
{
    public partial class Item
    {
        public int ItemId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}
