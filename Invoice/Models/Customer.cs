
using System;
using System.Collections.Generic;

namespace Invoice.models
{
    public partial class Customer
    {
        public Customer()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustPhone { get; set; }
        public string CustAddress { get; set; }
        public string CustAddiAddr { get; set; }
        public string CustEmail { get; set; }

        public ICollection<Invoice> Invoice { get; set; }
    }
}
