using Melidya.BLL;
using Melidya.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Melidya.AdminWebUI.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: AdminLogin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminLogin(Admin ladmin)
        {
            Admin admin = AdminBLL.getAdmin(ladmin.AUser);
            if (admin.APassword== ladmin.APassword)
            {
                Session["AdminLogin"] = admin;
                return RedirectToAction("categories", "Categories");
            }
            return RedirectToAction("categories", "Categories");
        }
    }
}