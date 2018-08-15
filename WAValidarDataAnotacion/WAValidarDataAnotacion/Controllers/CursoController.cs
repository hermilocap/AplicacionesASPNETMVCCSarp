using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAValidarDataAnotacion.Models;

namespace WAValidarDataAnotacion.Controllers
{
    public class CursoController : Controller
    {
    bd_validarEntities bd = new bd_validarEntities();

        // GET: Curso
     public ActionResult Index()
        {
            return View(bd.curso.ToList());
        }
    public ActionResult CrearCurso()
    {
        return View();
    }

    [HttpPost]
    public ActionResult CrearCurso(curso curso)
    {
        if (ModelState.IsValid) {
            bd.curso.Add(curso);
            bd.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }

}
}