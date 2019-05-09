using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Melidya.WebUI.Admin.Models
{
    public class ProductCategoryModel
    {
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public int ProductID { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}