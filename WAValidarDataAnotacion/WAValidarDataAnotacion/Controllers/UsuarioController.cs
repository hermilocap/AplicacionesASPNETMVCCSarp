using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAValidarDataAnotacion.Models;

namespace WAValidarDataAnotacion.Controllers
{
    public class UsuarioController : Controller
    {
        public bd_validarEntities bd = new bd_validarEntities();

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Validar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Validar(string user, string password)
        {
            Usuario us = bd.Usuario.FirstOrDefault(d => d.usuario_u == user & d.clave_u == password);
            if (us != null)
            {
                return RedirectToAction("Index", "Curso");
            }
            else
            {
                return RedirectToAction("NoHallado", "Usuario");
            } 
           
        }

        public ActionResult NoHallado()
        {
            ViewBag.Error = "No se encontro el usuario con esttos datos";
            return View();
        }
    }
}