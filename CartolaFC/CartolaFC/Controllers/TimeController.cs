using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
            return View(db.Times.Include(x => x.Tecnico).ToList());
        }

        public ActionResult Cadastrar()
        {
            ViewBag.ListaDeTecnicos = new SelectList(db.Tecnicos.ToList(), "TecnicoId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar([Bind(Exclude = "Tecnico")]Time time, int tecnicoId)
        {
            if (ModelState.IsValid)
            {
                time.Tecnico = db.Tecnicos.Find(tecnicoId);
                db.Times.Add(time);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(time);
        }

        public ActionResult Editar(int id)
        {
            var time = db.Times.Include(x => x.Tecnico).FirstOrDefault(x => x.TimeId == id);

            ViewBag.ListaDeTecnicos = new SelectList(db.Tecnicos.ToList(), "TecnicoId", "Nome", time.Tecnico.TecnicoId);

            return View(time);
        }

        [HttpPost]
        public ActionResult Editar([Bind(Exclude = "Tecnico")]Time time, int tecnicoId)
        {
            if (ModelState.IsValid)
            {
                var timeBanco = db.Times.Find(time.TimeId);
                timeBanco.Descricao = time.Descricao;
                timeBanco.Nome = time.Nome;
                timeBanco.AnoDeFundacao = time.AnoDeFundacao;

                timeBanco.Tecnico = db.Tecnicos.Find(tecnicoId);

                //db.Entry(timeBanco).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(time);
        }

        public ActionResult Excluir(int id)
        {
            var time = db.Times.Include(x => x.Tecnico).FirstOrDefault(x => x.TimeId == id);
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
            var time = db.Times.Include(x => x.Tecnico).FirstOrDefault(x => x.TimeId == id);
            return View(time);
        }
    }
}