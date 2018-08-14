using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEmpresa.Models;

namespace MVCEmpresa.Controllers
{

    public class AreaController : Controller
    {
        public AreaModelo model = new AreaModelo();


        // GET: Area
        public ActionResult Index()
        {
            return View(model.listaAreas());
        }
        public ActionResult Details(int id)
        {
            var area = model.buscarAreas(id);
            return View(area);
        }
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(area a) {
            try
            {
                if (model.insertarArea(a).Equals("OK"))
                {
                    return RedirectToAction("Index");

                }
                else {
                    return RedirectToAction("Create");
                }
            }
            catch { return View(); }

        }
        public ActionResult Edit(int id) {
            var area = model.buscarAreas(id);
            return View(area);

        }
        [HttpPost]
        public ActionResult Edit(int id, area a) {
            try {
                area area = new area();
                area.are_cod = id;
                area.are_des = a.are_des;
                if (model.ActualizarDatos(area).Equals("OK"))
                {
                    return RedirectToAction("Index");
                }
                else { return RedirectToAction("Edit"); }
            }
            catch { return View(); }
        }
        public ActionResult Delete(int id)
        {
            var area = model.buscarAreas(id);
            return View(area);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection colection) {
            try
            {
                if (model.EliminarArea(id).Equals("OK"))
                {
                    return RedirectToAction("Index");
                }
                else { return RedirectToAction("Delete"); }
            }
            catch {
                return View();
            }

        }


    }
}