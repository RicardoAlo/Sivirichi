using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_MVC_Sivirichi_A.Models
{
    public class ClsMatricula
    {
        public int codigo { get; set; }
        public string semestre { get; set; }
        public bool estado { get; set; }
        public double costo { get; set; }
    }
}