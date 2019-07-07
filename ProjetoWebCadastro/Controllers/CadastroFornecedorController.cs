using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoWebCadastro.Models;
using ProjetoWebCadastro.ViewModels;

namespace ProjetoWebCadastro.Controllers
{
    public class CadastroFornecedorController : Controller
    {
        

        private ApplicationDbContext db = new ApplicationDbContext();

        


      

        public ActionResult Index()
        {

            return View(db.Fornecedores.ToList());
        }

        public ActionResult NovoFornecedor()
        {
            var viewModel = new FornecedorCategoriaViewModel
            {
                Categorias = db.Categorias.ToList(),
                
            };
            return View("FornecedorCategoria", viewModel);
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cadastrofornecedor cadastrofornecedor = db.Fornecedores.Find(id);
            if (cadastrofornecedor == null)
            {
                return HttpNotFound();

            }
            var categorias = db.Categorias.ToList();

            var listaStringCategorias = FornecedorCategoriaViewModel.TransformarEmString(categorias);

            var viewModel = new FornecedorCategoriaViewModel
            {
                Categorias = db.Categorias.ToList(),
                
            };
            return View(cadastrofornecedor);

        }

       

        public ActionResult Create()
        {

            var fornecedores = db.Fornecedores.Include(e => e.Categoria).ToList();
            return View();

            var categoria = db.Categorias.ToList();

            var listaStringCategorias = FornecedorCategoriaViewModel.TransformarEmString(categoria);

            var viewModel = new FornecedorCategoriaViewModel
            {
                Categorias = db.Categorias.ToList(),
                
            };

        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CNPJ,RazaoSocial,NomeFantasia,Email,Endereco,Cidade,Estado,Telefone,DataDeCadastro,Categoria,CategoriaId,Status,Agencia,ContaCorrente")] cadastrofornecedor cadastrofornecedor)
        {
            ModelState.Remove("fornecedor.Categoria.Nome");
            if (!ModelState.IsValid)
            {
                var viewModel = new FornecedorCategoriaViewModel
                {
                    Fornecedores = cadastrofornecedor,
                    Categorias = db.Categorias.ToList(),
                };
                return View("EstabelecimentoForm", viewModel);
            }

            int? categoriaId = 0;
            if (!String.IsNullOrWhiteSpace(cadastrofornecedor.Categoria.Nome))
            {
                categoriaId = db.Categorias.
                    SingleOrDefault(c => c.Nome == cadastrofornecedor.Categoria.Nome).Id;
            }

            if (ModelState.IsValid)
            {
                db.Fornecedores.Add(cadastrofornecedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadastrofornecedor);
        }

        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cadastrofornecedor cadastrofornecedor = db.Fornecedores.Find(id);
            if (cadastrofornecedor == null)
            {
                return HttpNotFound();
            }
            var categorias = db.Categorias.ToList();
            var listaStringCategorias = FornecedorCategoriaViewModel.TransformarEmString(categorias);

            var viewModel = new FornecedorCategoriaViewModel
            {
                Categorias = db.Categorias.ToList(),
              
            };
            return View(cadastrofornecedor);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CNPJ,RazaoSocial,NomeFantasia,Email,Endereco,Cidade,Estado,Telefone,DataDeCadastro,Categoria,CategoriaId,Status,Agencia,ContaCorrente")] cadastrofornecedor cadastrofornecedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastrofornecedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadastrofornecedor);
        }

       
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            cadastrofornecedor cadastrofornecedor = db.Fornecedores.Find(id);
            if (cadastrofornecedor == null)
            {
                return HttpNotFound();
            }
            return View(cadastrofornecedor);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            cadastrofornecedor cadastrofornecedor = db.Fornecedores.Find(id);
            db.Fornecedores.Remove(cadastrofornecedor);
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
