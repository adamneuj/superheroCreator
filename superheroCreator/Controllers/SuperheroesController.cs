using superheroCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace superheroCreator.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext db;
        public SuperheroesController()
        {
            db = new ApplicationDbContext();
        }
        // GET: Superheroes
        public ActionResult Index()
        {
            return View();
        }
        // GET: List
        public ActionResult List()
        {
            List<Superhero> superheroes = db.Superheroes.ToList();
            return View(superheroes);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
        {
            Superhero superhero = db.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                db.Superheroes.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            Superhero superhero = db.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(id);
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            Superhero superhero = db.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superhero);
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                db.Superheroes.Remove(superhero);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(id);
            }
        }
    }
}
