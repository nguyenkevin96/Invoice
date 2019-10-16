using System;
using System.Collections.Generic;

namespace Invoice.models
{
    public partial class Car
    {
        public Car()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int CarId { get; set; }
        public DateTime CarDate { get; set; }
        public string CarYearmakemodel { get; set; }
        public int CarVin { get; set; }

        public ICollection<Invoice> Invoice { get; set; }
    }
}
