using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace ShipperWebsite.Controllers
{
    public class LoginController : BaseController
    {

        public LoginController()
        {
            CheckLogin = false;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}