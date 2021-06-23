using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyED_TP1.Objetos
{
    class Proyecto
    {
        public Proyecto(string cOD_PRO, string cOD_EMP, char etapa, char tipo, string cOD_Ciudad)
        {
            COD_PRO = cOD_PRO;
            COD_EMP = cOD_EMP;
            Etapa = etapa;
            Tipo = tipo;
            COD_Ciudad = cOD_Ciudad;
            Cantidad = 0;
        }

        public string COD_PRO { get; set; }
        public string COD_EMP { get; set; }
        public char Etapa { get; set; }
        public char Tipo { get; set; }
        public string COD_Ciudad { get; set; }
        public int Cantidad { get; set; }

    }
}
