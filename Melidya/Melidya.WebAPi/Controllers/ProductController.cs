using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Melidya.WebAPi.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<Product> GetProducts()
        {
            ProductBLL productBLL = new ProductBLL();
            return productBLL.GetProducts();
        }
    }
}