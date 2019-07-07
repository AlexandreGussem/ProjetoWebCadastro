using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoWebCadastro.Models;

namespace ProjetoWebCadastro.Controllers
{
    public class categoriafornecedorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

      
        public ActionResult Index()
        {
            return View(db.Categorias.ToList());
        }

       
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categoriafornecedor categoriafornecedor = db.Categorias.Find(id);
            if (categoriafornecedor == null)
            {
                return HttpNotFound();
            }
            return View(categoriafornecedor);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome")] categoriafornecedor categoriafornecedor)
        {
            if (ModelState.IsValid)
            {
                db.Categorias.Add(categoriafornecedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriafornecedor);
        }

       
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categoriafornecedor categoriafornecedor = db.Categorias.Find(id);
            if (categoriafornecedor == null)
            {
                return HttpNotFound();
            }
            return View(categoriafornecedor);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome")] categoriafornecedor categoriafornecedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriafornecedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriafornecedor);
        }

       
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            categoriafornecedor categoriafornecedor = db.Categorias.Find(id);
            if (categoriafornecedor == null)
            {
                return HttpNotFound();
            }
            return View(categoriafornecedor);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            categoriafornecedor categoriafornecedor = db.Categorias.Find(id);
            db.Categorias.Remove(categoriafornecedor);
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
