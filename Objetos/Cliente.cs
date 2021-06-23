using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyED_TP1.Objetos
{
    class Cliente
    {
        public Cliente(string nombre, string mail)
        {
            Nombre = nombre;
            Mail = mail;
        }

        public string Nombre { get; set; } //Nombre y Apellido
        public string Mail { get; set; }

    }
}
