using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio1_MVC_Sivirichi_A.Models;

namespace Laboratorio1_MVC_Sivirichi_A.Controllers
{
    public class Operaciones2Controller : Controller
    {
        // GET: Operaciones2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular(ClsOperaciones2 objOperacion)
        {

            if (objOperacion.operacion.Equals("S"))
            {
                objOperacion.resultado = objOperacion.valor1 + objOperacion.valor2;
            }
            else if (objOperacion.operacion.Equals("R"))
            {
                objOperacion.resultado = objOperacion.valor1 - objOperacion.valor2;
            }
            else if (objOperacion.operacion.Equals("M"))
            {
                objOperacion.resultado = objOperacion.valor1 * objOperacion.valor2;
            }
            else
            {
                objOperacion.resultado = objOperacion.valor1 / objOperacion.valor2;
            }
            return View(objOperacion);
        }
    }
}