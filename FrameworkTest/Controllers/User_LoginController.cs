using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FrameworkTest.Models;

namespace FrameworkTest.Controllers
{
    public class User_LoginController : Controller
    {
        private TestDB db = new TestDB();

        // GET: User_Login
        public ActionResult Index()
        {
            return View(db.User_Login.ToList());
        }

        // GET: User_Login/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Login user_Login = db.User_Login.Find(id);
            if (user_Login == null)
            {
                return HttpNotFound();
            }
            return View(user_Login);
        }

        // GET: User_Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User_Login/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserLogin_ID,UserLogin_CreatDT,UserLogin_Guid,UserLogin_Name,UserLogin_PassWord,UserLogin_State")] User_Login user_Login)
        {
            if (ModelState.IsValid)
            {
                db.User_Login.Add(user_Login);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user_Login);
        }

        // GET: User_Login/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Login user_Login = db.User_Login.Find(id);
            if (user_Login == null)
            {
                return HttpNotFound();
            }
            return View(user_Login);
        }

        // POST: User_Login/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserLogin_ID,UserLogin_CreatDT,UserLogin_Guid,UserLogin_Name,UserLogin_PassWord,UserLogin_State")] User_Login user_Login)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user_Login).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user_Login);
        }

        // GET: User_Login/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Login user_Login = db.User_Login.Find(id);
            if (user_Login == null)
            {
                return HttpNotFound();
            }
            return View(user_Login);
        }

        // POST: User_Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User_Login user_Login = db.User_Login.Find(id);
            db.User_Login.Remove(user_Login);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
