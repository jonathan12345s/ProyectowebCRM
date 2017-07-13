using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyetcoweb2;

namespace Proyetcoweb2.Controllers
{
    public class ReunionsController : Controller
    {
        private DB_Dev_JaipalEntities3 db = new DB_Dev_JaipalEntities3();

        // GET: Reunions
        public ActionResult Index()
        {
            return View(db.Reunions.ToList());
        }

        // GET: Reunions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunion reunion = db.Reunions.Find(id);
            if (reunion == null)
            {
                return HttpNotFound();
            }
            return View(reunion);
        }

        // GET: Reunions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reunions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Titulo,Dia_hora,IDUsuario,Virtual,Cliente")] Reunion reunion)
        {
            if (ModelState.IsValid)
            {
                db.Reunions.Add(reunion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reunion);
        }

        // GET: Reunions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunion reunion = db.Reunions.Find(id);
            if (reunion == null)
            {
                return HttpNotFound();
            }
            return View(reunion);
        }

        // POST: Reunions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titulo,Dia_hora,IDUsuario,Virtual,Cliente")] Reunion reunion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reunion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reunion);
        }

        // GET: Reunions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reunion reunion = db.Reunions.Find(id);
            if (reunion == null)
            {
                return HttpNotFound();
            }
            return View(reunion);
        }

        // POST: Reunions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reunion reunion = db.Reunions.Find(id);
            db.Reunions.Remove(reunion);
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
