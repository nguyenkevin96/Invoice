using System;
using System.Collections.Generic;

namespace Invoice.models
{
    public partial class Invoice
    {
        public Invoice()
        {
            Item = new HashSet<Item>();
        }

        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public DateTime InvoiceDate { get; set; }

        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Item> Item { get; set; }
    }
}
