using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDbFirstApproachExample.Models;

namespace EFDbFirstApproachExample.Areas.Admin.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands/Index
        public ActionResult Index()
        {
            return View();
        }
    }
}


