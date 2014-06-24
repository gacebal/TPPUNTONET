using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPMVC.Models
{
    public class FactorModel
    {
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Display(Name = "Ponderacion")]
        public short Ponderacion { get; set; }

        [Display(Name = "Categoria 1")]
        public string Categoria1 { get; set; }

        [Display(Name = "Categoria 2")]
        public string Categoria2 { get; set; }

        [Display(Name = "Categoria 3")]
        public string Categoria3 { get; set; }
    }
}