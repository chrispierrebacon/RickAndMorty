﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RickAndMortyFE.Controllers
{
    public class RAMController : Controller
    {
        // GET: RAM
        public ActionResult Index()
        {
            return View();
        }
    }
}