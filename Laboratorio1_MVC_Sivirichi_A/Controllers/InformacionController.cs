using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio1_MVC_Sivirichi_A.Controllers
{
    public class InformacionController : Controller
    {
        // GET: Informacion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Datos()
        {
            ViewBag.Escuela = "Ingeniera de Sistemas";
            ViewBag.Curso = "Programacion Web II";
            ViewBag.Cantidad = 12;

            ViewData["Tema"] = "ASP.NET MVC";
            ViewData["Unidad"] = 1;
 
            return View();
        }
    }
}