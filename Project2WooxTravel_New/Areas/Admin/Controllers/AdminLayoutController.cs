using Project2WooxTravel_New.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel_New.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        TravelContext context=new TravelContext();
        // GET: Admin/AdminLayout
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            var values = context.Messages.OrderByDescending(x => x.MessageID).Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFooter() 
        {
            return PartialView();
        }
        
        public PartialViewResult PartialScript() 
        {
            return PartialView();
        }
    }
}