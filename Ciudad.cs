using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyED_TP1
{
    class Ciudad
    {
        private string nombre;
        private string codigo;
        private int cantEmpresas=0;

        public Ciudad(string nombre, string codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int CantEmpresas { get => cantEmpresas; set => cantEmpresas = value; }
    }
}
