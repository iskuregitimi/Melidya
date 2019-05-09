using Melidya.BLL;
using Melidya.Entities;
using Melidya.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Controllers
{
    public class ProfileController : Controller
    {

        // GET: Profile
        public ActionResult UserProfile()
        {
            var user =(Customer) Session["Login"];
            var userid= CustomerManager.GetCustomer(user.CustomerID);
            return View(userid);
        }
    
         [HttpGet]
        public ActionResult UpdateProfile()
        {
            var user = (Customer)Session["Login"];

           

            return View("UpdateProfile",user);
        }
        [HttpPost]
        public ActionResult UpdateProfile(Customer cus)
        {
            CustomerManager.UpdateCustomer(cus);
            return View("UserProfile",cus);
        }
    }
}