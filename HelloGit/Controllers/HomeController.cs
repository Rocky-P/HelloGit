﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloGit.Controllers
{
    public class HomeController : Controller
    {

        public void Index()
        {
            Console.Write("<h1> Hellow from Index </h1>");
        }

        public void Bar()
        {
            Console.Write("<h1> Bar </h1>");
        }
    }
}
