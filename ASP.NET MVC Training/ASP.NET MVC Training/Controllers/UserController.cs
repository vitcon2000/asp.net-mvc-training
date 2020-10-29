using ASP.NET_MVC_Training.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Training.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            UserTB userModel = new UserTB();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(UserTB userTB)
        {
            using (VietISEntities dbModel = new VietISEntities())
            {
                dbModel.UserTBs.Add(userTB);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful!";
            return View("AddOrEdit");
        }
    }
}