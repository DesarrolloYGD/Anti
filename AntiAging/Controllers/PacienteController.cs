using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AntiAging.Models;

namespace AntiAging.Controllers
{
    public class PacienteController : Controller
    {
        private AntiAgingEntities db = new AntiAgingEntities();
        // GET: Paciente
        public ActionResult Index()
        {
            
            return View();
        }


        public ActionResult Lista(int? idSexo)
        {

            ViewBag.idSexo = new SelectList(db.PACIENTE.ToList(), "idSexo", "descSexo", idSexo);
            

            List<PACIENTE> lista = db.PACIENTE.ToList();
            if (idSexo != null)
            {
                lista = lista.Where(r => r.idSexo == idSexo ).ToList();
            }
            else
            {
                lista = lista.ToList();
            }


            return View(lista);
        }

        public ActionResult Paciente(int? idSexo)
        {

            ViewBag.idSexo = new SelectList(db.PACIENTE.ToList(), "idSexo", "descSexo", idSexo);
            ViewBag.idSexo = ViewBag.idSexo;


            List<PACIENTE> lista = db.PACIENTE.ToList();
            if (idSexo != null)
            {
                lista = lista.Where(r => r.idSexo == idSexo).ToList();
            }
            else
            {
                lista = lista.ToList();
            }


            return View(lista);
        }



        // GET: Paciente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Paciente/Create
        public ActionResult Create()
        {
            var temp = new PacienteViewModel();
            ViewBag.IDSexo = new SelectList(db.Sexo, "idSexo", "DescSexo");
            return View();
        }

        // POST: Paciente/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "id_paciente,nombre,apellido,peso,edad,rut,idSexo")]PACIENTE model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.PACIENTE.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            return View(model);
        }

        // GET: Paciente/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Paciente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Paciente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Paciente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
