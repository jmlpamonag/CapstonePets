﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace blah.Controllers
{
    public class ClientsController : Controller
    {


        // GET: Clients
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create() {
            return View();
        }
    }

}