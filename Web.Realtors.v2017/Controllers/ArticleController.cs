﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Realtors.Controllers
{
    public class ArticleController : Controller
    {
        //Default
        public ActionResult Index()
        {
            
            return View();
            
        }

		public ActionResult AddNew()
		{
			
			return View();

		}
	}
}