using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyED_TP1
{
    class Ciudad
    {
        public Ciudad(string cOD_Ciudad, string nombre)
        {
            COD_Ciudad = cOD_Ciudad;
            Nombre = nombre;
        }

        public string COD_Ciudad { get; set; }
        public string Nombre { get; set; }

    }
}
