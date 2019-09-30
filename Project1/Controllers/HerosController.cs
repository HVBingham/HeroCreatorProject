using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class HerosController : Controller
    {
        ApplicationDbContext db;
        public HerosController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var listOfHeros = db.hero1s.ToList();
            return View(listOfHeros);
        }

        // GET: Heros/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Heros/Create
        public ActionResult Create()
        {
            CreatorHero1 newHero = new CreatorHero1();
            return View(newHero);
        }

        // POST: Heros/Create
        [HttpPost]
        public ActionResult Create(CreatorHero1 hero)

        {
            try
            {
                db.hero1s.Add(hero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Heros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Heros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CreatorHero1 hero)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Heros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Heros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CreatorHero1 hero)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
