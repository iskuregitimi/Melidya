using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Melidya.WebUI.Admin.Models
{
    public class ProductModel
    {
        public string ProductName { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public short UnitInStock { get; set; }

        public short UnitsOnOrder { get; set; }

        public short ReorderLevel { get; set; }

        public bool Discontinued { get; set; }
    }
}