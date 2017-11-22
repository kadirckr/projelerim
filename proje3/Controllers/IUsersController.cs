using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proje3.Data;
using proje3.Model;
using proje3.Data.Repositories;

namespace proje3.Controllers
{
    public class IUsersController : Controller
    {
        private denemeEntities db = new denemeEntities();
        IUserRepository _repo;

        //public IUsersController(Repository<User> repo)
        //{
        //    _repo = repo;
        //}

        //GET: IUsers

        public IUsersController(IUserRepository usera)
        {
            _repo = usera;
        }
        public ActionResult Index()
        {
           var a= _repo.GetAll();
            //_repo = new Repository<User>(db);
            return View(_repo.GetAll());
        }

        //// GET: IUsers/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    IUser iUser = db.IUsers.Find(id);
        //    if (iUser == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(iUser);
        //}

        //// GET: IUsers/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: IUsers/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Ad,Soyad,TC")] IUser iUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.IUsers.Add(iUser);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(iUser);
        //}

        //// GET: IUsers/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    IUser iUser = db.IUsers.Find(id);
        //    if (iUser == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(iUser);
        //}

        //// POST: IUsers/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Ad,Soyad,TC")] IUser iUser)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(iUser).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(iUser);
        //}

        //// GET: IUsers/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    IUser iUser = db.IUsers.Find(id);
        //    if (iUser == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(iUser);
        //}

        //// POST: IUsers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    IUser iUser = db.IUsers.Find(id);
        //    db.IUsers.Remove(iUser);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
