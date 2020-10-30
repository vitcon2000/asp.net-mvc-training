using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using User_Manager.Models;
using PagedList;
namespace User_Manager.Controllers
{
    public class UserController : Controller
    {
        VietISEntities db = new VietISEntities();

        //Get: User/Index
        public ActionResult Index(int? page)
        {
            int pageSize = 10;
            int pageIndex = (page ?? 1);
            return View(db.Users.ToList().ToPagedList(pageIndex, pageSize));
        }

        //Get: User/Create
        public ActionResult Create()
        {
            return View();
        }

        //Post: User/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Birthday,Email,PhoneNumber")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //Get: User/Edit/id
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //Post: UserTest/Edit/id
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Birthday,Email,PhoneNumber")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

        //Get: UserTest/Delete/id
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //Post: UserTest/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}