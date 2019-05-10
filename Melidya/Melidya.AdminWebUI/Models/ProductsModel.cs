using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Melidya.AdminWebUI.Models
{
    public class ProductsModel
    {
        
        public string ProductName{ get; set; }
        public int Categories { get; set; }
        public decimal UnitPrice{ get; set; }
        public string QuantityPerUnit { get; set; }
    }
}