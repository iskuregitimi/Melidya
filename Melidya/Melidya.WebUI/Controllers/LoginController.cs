using Melidya.BLL;
using Melidya.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.WebUI.Controllers
{
    public class LoginController : Controller
    {
        CustomerBLL customerbll = new CustomerBLL();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Customers cust)
        {
            Customers customer= customerbll.GetCustomer(cust.CustomerID);

            if (customer!=null)
            {
                if (customer.Password==cust.Password)//Şifre Hatalı
                {
                    Session["Login"] = customer;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
            else //KullanıcıAdı Hatalı
            {
                return View();
            }
            
        }

        public ActionResult Logout()
        {
            Session.Remove("Login");
            Session.Clear();             
            return RedirectToAction("Index","Home");
        }

        public ActionResult Profil()
        {
            Customers cust = new Customers();
            if (Session["Login"] != null)
            {
                Customers customer = Session["Login"] as Customers;
                cust = customerbll.GetCustomer(customer.CustomerID);
            }

            return View(cust);
        }

        [HttpPost]
        public ActionResult Profil(Customers customer)
        {
            customerbll.UpdateCustomer(customer);
            return RedirectToAction("Profil");
        }
    }
}