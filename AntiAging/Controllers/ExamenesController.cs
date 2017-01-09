using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AntiAging.Models;

namespace AntiAging.Controllers
{
    public class ExamenesController : Controller
    {
        AntiAgingEntities db = new AntiAgingEntities();
        // GET: Examenes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Examenes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        // GET: Examenes/Create/id
        public ActionResult Create(int? id)
        {

            PACIENTE paciente = db.PACIENTE.Find(id);

            //Grupo de Viewbags para visualizar los datos del paciente al cual se le está asignando la lista de examenes
            ViewBag.nombrepaciente = paciente.NOMBRE;
            ViewBag.idpaciente = paciente.ID_PACIENTE;
            ViewBag.apellidopaciente = paciente.APELLIDO;
            ViewBag.rutpaciente = paciente.RUT;
            ViewBag.pesopaciente = paciente.PESO;
            ViewBag.edadpaciente = paciente.EDAD;
            if (paciente.idSexo == 1)
            {
                ViewBag.sexopaciente = "Masculino";
            }
            else
            {
                ViewBag.sexopaciente = "Femenino";
            }
            //-----------------------------------------------------------------
            int sexo = paciente.idSexo.Value;

            List<EXAMENES> lista = db.EXAMENES.ToList();
            var model = new ExamenesViewModel
            {

                listaExamenes = db.EXAMENES.OrderBy(p => p.ID_EXAMEN).Where(r => r.idSexo == sexo).Select(p => new SelectListItem { Value = p.ID_EXAMEN.ToString(), Text = p.NOMBRE }).ToList()
            };
            //*******************************versiín 1******************************************
            //List<EXAMENES> lista = db.EXAMENES.ToList();
            //lista = lista.OrderBy(r => r.ID_EXAMEN).Where(r => r.idSexo == sexo).ToList();
            //var m = new MultiSelectList(lista, "ID_EXAMEN", "NOMBRE");

            /*                    @foreach (var item in (MultiSelectList)ViewData["examenes"])
                    {
                        <input type="checkbox" name="groups" value="@(item.Value)"
                               id="group@(item.Value)"
                               @(item.Selected ? "checked=\"checked\"" : String.Empty) />
                        <label for="group@(item.Value)">@(item.Text)</label><br />
                    }*/
            
            //ViewData["examenes"] = m;
            return View(model);

        }

        // POST: Examenes/Create
        [HttpPost]
        public ActionResult Create(ExamenesViewModel model)
        {

            var idPac = ViewBag.idpaciente;
            PACIENTE paciente = db.PACIENTE.Find(idPac);
            int sexo = paciente.idSexo.Value;
            try
            {
                if (ModelState.IsValid)
                {
                    var exam = string.Join(",", model.seleccionados);
                    return RedirectToAction("Exito");
                }
                model.listaExamenes = db.EXAMENES.OrderBy(p => p.ID_EXAMEN).Where(r => r.idSexo == sexo).Select(p => new SelectListItem { Value = p.ID_EXAMEN.ToString(), Text = p.NOMBRE }).ToList();
                return View(model);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Exito()
        {
            return View();
        }


        // GET: Examenes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Examenes/Edit/5
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

        // GET: Examenes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Examenes/Delete/5
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
