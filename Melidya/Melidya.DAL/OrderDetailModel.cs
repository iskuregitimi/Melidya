using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melidya.DAL
{
    public class OrderDetailModel
    {
        public string Status { get; set; }
        public int OrderID { get; set; }
        public string ContactName { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? TotalAmount { get; set; }
        public string ShipAddress { get; set; }
    }
}
