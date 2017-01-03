using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AntiAging.Models
{
    public class PacienteViewModel
    {
        public int id_paciente{ get; set; }
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Genero Sexo { get; set; }
        public int edad { get; set; }
        public int peso { get; set; }

        public enum Genero
        {
            Hombre,
            Mujer
        }

    }
}