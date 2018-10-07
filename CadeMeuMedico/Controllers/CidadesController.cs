using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class CidadesController : Controller
    {
        private EntitiesCadeMeuMedicoBD db = new EntitiesCadeMeuMedicoBD();

        // GET: Cidades
        public ActionResult Index()
        {
            var cidades = db.Cidades.ToList();

            return View(cidades);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Cidades cidade)
        {
            if (ModelState.IsValid)
            {
                db.Cidades.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cidade);
        }

        public ActionResult Editar(long id)
        {
            var cidade = db.Cidades.Find(id);
            
            return View(cidade);
        }

        [HttpPost]
        public ActionResult Editar(Cidades cidade)
        {

            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cidade);

        }

        public string Excluir(long id)
        {
            try
            {
                var cidade = db.Cidades.Find(id);
                db.Cidades.Remove(cidade);
                db.SaveChanges(); 
                return Boolean.TrueString;
            }
            catch
            {
                return Boolean.FalseString;
            }
            
        }
    }
}