using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2WooxTravel_New.Context;

namespace Project2WooxTravel_New.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        TravelContext context=new TravelContext();
        // GET: Admin/Category

        [Authorize]
        public ActionResult CategoryList()
        {
            var values=context.Categories.ToList();
            return View(values);
        }
    }
}