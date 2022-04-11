using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio1_MVC_Sivirichi_A.Models;

namespace Laboratorio1_MVC_Sivirichi_A.Controllers
{
    public class Operaciones1Controller : Controller
    {
        // GET: Operaciones1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcular()
        {
            ClsOperaciones1 objOperacion = new ClsOperaciones1();
            objOperacion.valor1 = Convert.ToDouble(Request.Form["num1"]);
            objOperacion.valor2 = Convert.ToDouble(Request.Form["num2"]);

            objOperacion.operacion = Request.Form["operacion"];

         

            if (Request.Form["operacion"].Equals("S"))
            {
                objOperacion.resultado = objOperacion.valor1 + objOperacion.valor2;
            }
            else if (Request.Form["operacion"].Equals("R"))
            {
                objOperacion.resultado = objOperacion.valor1 - objOperacion.valor2;
            }
            else if (Request.Form["operacion"].Equals("M"))
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