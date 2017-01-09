using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AntiAging.Models;
using System.Web.Mvc;

namespace AntiAging.Models
{
    public class ExamenesViewModel
    {
        public List<SelectListItem> listaExamenes { get; set; }
        public IList<string> seleccionados { get; set; }
    }
}