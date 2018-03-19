using AutoMapper;
using ErasmusDDD.Application.Interface;
using ErasmusDDD.Domain.Entities;
using ErasmusDDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ErasmusDDD.MVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly ILivroAppService _livroApp;

        public LivrosController(ILivroAppService livroApp)
        {
            _livroApp = livroApp;
        }

        // GET: Livro
        public ActionResult Index()
        {
            var livroVM = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroVM>>(_livroApp.GetAll());
            return View(livroVM);
        }

        // TODO Erasmus
        public ActionResult Search(string nome)
        {
            var livroVM = Mapper.Map<IEnumerable<Livro>, IEnumerable<LivroVM>>(_livroApp.Search(nome));
            return View(livroVM);
        }

        // GET: Livro/Details/5
        public ActionResult Details(int id)
        {
            var livro = _livroApp.Get(id);
            var livroVM = Mapper.Map<Livro, LivroVM>(livro);

            return View(livroVM);
        }

        // GET: Livro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LivroVM livro)
        {
            if (ModelState.IsValid)
            {
                var livroDomain = Mapper.Map<LivroVM, Livro>(livro);
                _livroApp.Add(livroDomain);

                return RedirectToAction("Index");
            }

            return View(livro);
        }

        // GET: Livro/Edit/5
        public ActionResult Edit(int id)
        {
            var livro = _livroApp.Get(id);
            var livroVM = Mapper.Map<Livro, LivroVM>(livro);

            return View(livroVM);
        }

        // POST: Livro/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, LivroVM livro)
        {
            if (ModelState.IsValid)
            {
                var livroDomain = Mapper.Map<LivroVM, Livro>(livro);
                _livroApp.Edit(livroDomain);

                return RedirectToAction("Index");
            }

            return View(livro);
        }

        // GET: Livro/Delete/5
        public ActionResult Delete(int id)
        {
            var livro = _livroApp.Get(id);
            var livroVM = Mapper.Map<Livro, LivroVM>(livro);

            return View(livroVM);
        }

        // POST: Livro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var livro = _livroApp.Get(id);
            _livroApp.Remove(livro);

            return RedirectToAction("Index");
        }
    }
}
