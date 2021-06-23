using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyED_TP1
{
    class Empresa
    {
        public Empresa(string cOD_EMP, string nombre, string direccion, string mail, string telefono, string cOD_Ciudad)
        {
            COD_EMP = cOD_EMP;
            Nombre = nombre;
            Direccion = direccion;
            Mail = mail;
            Telefono = telefono;
            COD_Ciudad = cOD_Ciudad;
        }

        //PROPIEDADES
        public string COD_EMP { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string COD_Ciudad { get; set; }
    }
}
