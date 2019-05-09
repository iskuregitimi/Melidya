using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Melidya.AdminWebUI.Models
{
    public class ProductsModel
    {
        
        public string ProductName{ get; set; }
        public int CateegoriesID { get; set; }
        public decimal UnittPrice{ get; set; }
    }
}