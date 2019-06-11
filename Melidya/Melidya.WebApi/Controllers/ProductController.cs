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
        public List<Product> GetProducts()
        {
            ProductBLL product = new ProductBLL();
            return product.GetProducts();
        }
    }
}