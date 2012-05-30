using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CartolaFC.Infra;
using CartolaFC.Models;

namespace CartolaFC.Controllers
{
    public class TimeController : Controller
    {
        private DbComum db = new DbComum();

        public ActionResult Index()
        {
            return View(db.Times.ToList());
        }

        
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Time time)
        {
            if (ModelState.IsValid)
            {
                db.Times.Add(time);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(time);
        }

        public ActionResult Editar(int id)
        {
            var time = db.Times.Find(id);
            return View(time);
        }

        [HttpPost]
        public ActionResult Editar(Time time)
        {
            if (ModelState.IsValid)
            {
                db.Entry(time).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(time);
        }

        public ActionResult Excluir(int id)
        {
            var time = db.Times.Find(id);
            return View(time);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ConfirmaExcluir(int id)
        {
            var time = db.Times.Find(id);
            db.Times.Remove(time);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int id)
        {
            var time = db.Times.Find(id);
            return View(time);
        }
    }
}
