﻿using System;
using System.Web.Mvc;

namespace ShipperWebsite.Controllers
{
    public class MapController : BaseController
    {
        //
        // GET: /Map/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suggest(String id) {
            ViewBag.OrderId = id;
            return View();
        }

    }
}