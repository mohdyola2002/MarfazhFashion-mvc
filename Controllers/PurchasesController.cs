﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarfazahFashion.Controllers
{
    public class PurchasesController : Controller
    {
        // GET: Purchases
        public ActionResult New()
        {
            return View();
        }
    }
}