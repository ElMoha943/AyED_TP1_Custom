using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyED_TP1
{
    class Empresa
    {
        //PROPIEDADES
        private string cod_emp;
        private string nombre;
        private string direccion;
        private string mail;
        private long telefono;
        private string cod_ciudad;

        //CONSTRUCTOR
        public Empresa(string cod_emp, string nombre, string direccion, string mail, long telefono, string cod_ciudad)
        {
            this.Cod_emp = cod_emp;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Mail = mail;
            this.Telefono = telefono;
            this.Cod_ciudad = cod_ciudad;
        }

        //GETS y Sets
        public string Cod_emp { get => cod_emp; set => cod_emp = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Mail { get => mail; set => mail = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string Cod_ciudad { get => cod_ciudad; set => cod_ciudad = value; }

        public override string ToString()
        {
            return "COD_EMP: " + cod_emp + "\nNomnbre: " + nombre + "\nDireccion: " + direccion + "Mail: " + mail + "\nTelefono: " + telefono + "\nCOD_CIUDAD: " + cod_ciudad;
        }
    }
}
