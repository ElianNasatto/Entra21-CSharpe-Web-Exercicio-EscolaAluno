﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View.Controllers
{
    public class TelaInicialController : Controller
    {
        // GET: IndexTelaInicial
        public ActionResult Index()
        {
            return View();
        }
    }
}