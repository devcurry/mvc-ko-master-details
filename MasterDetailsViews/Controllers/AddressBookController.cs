using MasterDetailsViews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterDetailsViews.Controllers
{
    public class AddressBookController : Controller
    {
        private MasterDetailsViewsContext db = new MasterDetailsViewsContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(int? var)
        {
            List<User> users = db.Users.Include("Addresses").ToList();
            return Json(new { Users = users });
        }

    }
}
