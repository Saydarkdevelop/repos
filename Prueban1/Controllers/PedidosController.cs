using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Prueban1.Models;

namespace Prueban1.Controllers
{
    public class PedidosController : Controller
    {
        private DoñasjuanitasEntities db = new DoñasjuanitasEntities();

        // GET: Pedidos
        public ActionResult Index()
        {
            var pedidos = db.Pedidos.Include(p => p.Clientes).Include(p => p.Productos).Include(p => p.Productos1).Include(p => p.TipoCliente);
            return View(pedidos.ToList());
        }

        // GET: Pedidos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pedidos pedidos = db.Pedidos.Find(id);
            if (pedidos == null)
            {
                return HttpNotFound();
            }
            return View(pedidos);
        }

        // GET: Pedidos/Create
        public ActionResult Create()
        {
            ViewBag.Nombre = new SelectList(db.Clientes, "ID", "Nombre");
            ViewBag.Descuento = new SelectList(db.Productos, "ID", "NombreP");
            ViewBag.NombreP = new SelectList(db.Productos, "ID", "NombreP");
            ViewBag.Tipo = new SelectList(db.TipoCliente, "ID", "Tipo");
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NombreP,Nombre,Tipo,Descuento")] Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                db.Pedidos.Add(pedidos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Nombre = new SelectList(db.Clientes, "ID", "Nombre", pedidos.Nombre);
            ViewBag.Descuento = new SelectList(db.Productos, "ID", "NombreP", pedidos.Descuento);
            ViewBag.NombreP = new SelectList(db.Productos, "ID", "NombreP", pedidos.NombreP);
            ViewBag.Tipo = new SelectList(db.TipoCliente, "ID", "Tipo", pedidos.Tipo);
            return View(pedidos);
        }

        // GET: Pedidos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pedidos pedidos = db.Pedidos.Find(id);
            if (pedidos == null)
            {
                return HttpNotFound();
            }
            ViewBag.Nombre = new SelectList(db.Clientes, "ID", "Nombre", pedidos.Nombre);
            ViewBag.Descuento = new SelectList(db.Productos, "ID", "NombreP", pedidos.Descuento);
            ViewBag.NombreP = new SelectList(db.Productos, "ID", "NombreP", pedidos.NombreP);
            ViewBag.Tipo = new SelectList(db.TipoCliente, "ID", "Tipo", pedidos.Tipo);
            return View(pedidos);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NombreP,Nombre,Tipo,Descuento")] Pedidos pedidos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedidos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Nombre = new SelectList(db.Clientes, "ID", "Nombre", pedidos.Nombre);
            ViewBag.Descuento = new SelectList(db.Productos, "ID", "NombreP", pedidos.Descuento);
            ViewBag.NombreP = new SelectList(db.Productos, "ID", "NombreP", pedidos.NombreP);
            ViewBag.Tipo = new SelectList(db.TipoCliente, "ID", "Tipo", pedidos.Tipo);
            return View(pedidos);
        }

        // GET: Pedidos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pedidos pedidos = db.Pedidos.Find(id);
            if (pedidos == null)
            {
                return HttpNotFound();
            }
            return View(pedidos);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pedidos pedidos = db.Pedidos.Find(id);
            db.Pedidos.Remove(pedidos);
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
