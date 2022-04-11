using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio1_MVC_Sivirichi_A.Models;

namespace Laboratorio1_MVC_Sivirichi_A.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            //Instanciar la clase
            ClsPersona objPersona = new ClsPersona();

            objPersona.apellido = "Lanchipa Valencia";
            objPersona.nombre = "Enrique";
            objPersona.sexo = true;
            objPersona.peso = 78.85;
            objPersona.edad = 35;

            return View(objPersona);
        }
    }
}