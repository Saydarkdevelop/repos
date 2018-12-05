using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Doña_Juanita.Models;

namespace Doña_Juanita.Controllers
{
    public class TipoClientesController : Controller
    {
        private DoñaJuanitaEntities db = new DoñaJuanitaEntities();

        // GET: TipoClientes
        public ActionResult Index()
        {
            return View(db.TipoCliente.ToList());
        }

        // GET: TipoClientes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCliente tipoCliente = db.TipoCliente.Find(id);
            if (tipoCliente == null)
            {
                return HttpNotFound();
            }
            return View(tipoCliente);
        }

        // GET: TipoClientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoClientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Tipo")] TipoCliente tipoCliente)
        {
            if (ModelState.IsValid)
            {
                db.TipoCliente.Add(tipoCliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoCliente);
        }

        // GET: TipoClientes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCliente tipoCliente = db.TipoCliente.Find(id);
            if (tipoCliente == null)
            {
                return HttpNotFound();
            }
            return View(tipoCliente);
        }

        // POST: TipoClientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Tipo")] TipoCliente tipoCliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoCliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoCliente);
        }

        // GET: TipoClientes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoCliente tipoCliente = db.TipoCliente.Find(id);
            if (tipoCliente == null)
            {
                return HttpNotFound();
            }
            return View(tipoCliente);
        }

        // POST: TipoClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TipoCliente tipoCliente = db.TipoCliente.Find(id);
            db.TipoCliente.Remove(tipoCliente);
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
