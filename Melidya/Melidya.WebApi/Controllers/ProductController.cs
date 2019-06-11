using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Melidya.WebApi.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<Product> GetProducts()
        {
            ProductBLL product = new ProductBLL();

            return product.GetProducts();
        }


    }
}