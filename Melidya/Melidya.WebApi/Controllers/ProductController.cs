using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Melidya.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<Product> GetProducts()
        {
            ProductBLL productbll = new ProductBLL();
            return productbll.GetProducts();
        }
    }
}