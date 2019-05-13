using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Melidya.Entity
{
    public class OrderModel
    {
        public int OrderID { get; set; }

        public string ContactName { get; set; }

        public DateTime? OrderDate { get; set; }

        public decimal? TotalAmount { get; set; }

        public string ShipAddress { get; set; }

        public string Status { get; set; }
    }
}