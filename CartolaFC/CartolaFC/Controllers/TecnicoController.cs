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
    public class TecnicoController : Controller
    {
        private readonly DbComum db = new DbComum();

        public ActionResult Index()
        {
            return View(db.Tecnicos.ToList());
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Tecnico tecnico)
        {
            if (ModelState.IsValid)
            {
                db.Tecnicos.Add(tecnico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tecnico);
        }

        public ActionResult Editar(int id)
        {
            var tecnico = db.Tecnicos.Find(id);
            return View(tecnico);
        }

        [HttpPost]
        public ActionResult Editar(Tecnico tecnico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tecnico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tecnico);
        }

        public ActionResult Excluir(int id)
        {
            var tecnico = db.Tecnicos.Find(id);
            return View(tecnico);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult ConfirmaExcluir(int id)
        {
            var tecnico = db.Tecnicos.Find(id);
            db.Tecnicos.Remove(tecnico);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int id)
        {
            var tecnico = db.Tecnicos.Find(id);
            return View(tecnico);
        }
    }
}
