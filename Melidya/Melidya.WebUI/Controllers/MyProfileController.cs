using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Melidya.BLL;

namespace Melidya.WebUI.Controllers
{
    public class MyProfileController : Controller
    {
        // GET: MyProfile
        public ActionResult Index()
        {
            var customerid = Session["CustomerID"].ToString();
           var customer= CustomerBLL.GetCustomers(customerid);
            return View(customer);
        }
    }
}