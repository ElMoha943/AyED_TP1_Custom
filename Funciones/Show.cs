using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyED_TP1
{
    public class Show
    {
        Altas a = new(); //Crea una instancia de Altas.cs lo que nos permite usar sus funciones.
        public void showEmpresa()
        {
            char opt;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU EMPRESAS DESARROLLADORAS :\n\n1. Alta de CIUDADES \n2. Alta de EMPRESAS \n3. Alta de PROYECTOS\n4. Alta de Productos \n0. Volver al menú principal");
                do
                {
                    opt = Console.ReadKey().KeyChar;
                } while (opt != '1' && opt != '2' && opt != '3' && opt != '4' && opt != '0');
                switch (opt)
                {
                    case '1':
                        a.altaCiudad();
                        break;

                    case '2':
                        a.altaEmpresa();
                        break;

                    case '3':
                        a.altaProyecto();
                        break;

                    case '4':
                        a.altaProducto();
                        break;
                }
            } while (opt != '0'); //CONDICION DE SALIDA
        }

        public void showCliente()
        {
            char opt;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU CLIENTES :\n\n1. Alta de Clientes \n2. Consulta de PROYECTOS\n0. Volver al menú principal");
                do
                {
                    opt = Console.ReadKey().KeyChar;
                } while (opt != '1' && opt != '2' && opt != '0');
                switch (opt)
                {
                    case '1':
                        a.altaCliente();
                        break;

                    case '2':
                        a.getProyectos();
                        break;
                }
            } while (opt != '0'); //CONDICION DE SALIDA
        }
    }
}
