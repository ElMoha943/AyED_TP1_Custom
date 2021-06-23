using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyED_TP1
{
    public class Altas
    {
        List<Empresa> Empresas = new();
        List<Ciudad> Ciudades = new();
        List<Proyecto> Proyectos = new();
        List<Cliente> Clientes = new();
        public void altaEmpresa()
        {
            string cod_emp, nombre, direccion, mail, telefono, cod_ciudad;
            Console.Clear();
            Console.WriteLine("Ingrese el codigo de la empresa.");
            cod_emp = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la empresa.");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la direccion de la empresa.");
            direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el mail de la empresa.");
            mail = Console.ReadLine();
            Console.WriteLine("Ingrese el telefono de la empresa.");
            telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo de la ciudad asociada a la empresa.");
            cod_ciudad = Console.ReadLine();
            Empresas.Add(new Empresa(cod_emp, nombre, direccion, mail, telefono, cod_ciudad));
        }

        public void altaCiudad()
        {
            string cod_ciudad, nombre;
            Console.Clear();
            Console.WriteLine("Ingrese el codigo de la ciudad.");
            cod_ciudad = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la ciudad.");
            nombre = Console.ReadLine();
            Ciudades.Add(new Ciudad(cod_ciudad, nombre));
        }

        public void altaProyecto()
        {
            string cod_pro, cod_emp, cod_ciudad;
            char etapa, tipo;
            Console.Clear();
            Console.WriteLine("Ingrese el codigo del proyecto.");
            cod_pro = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo de la empresa.");
            cod_emp = Console.ReadLine();
            Console.WriteLine("Ingrese la etapa del proyecto.\nP. Preventa\nO. Obra\nT. Terminado");
            etapa = Console.ReadKey().KeyChar;
            Console.WriteLine("Ingrese el tipo de proyecto.\nC. Casa\nD. Departamento\nO. Oficina\nL. Lotes");
            tipo = Console.ReadKey().KeyChar;
            Console.WriteLine("Ingrese el codigo de la ciudad.");
            cod_ciudad = Console.ReadLine();
            Proyectos.Add(new Proyecto(cod_pro, cod_emp, etapa, tipo, cod_ciudad));
        }

        public void altaProducto() //UNUSED
        {
            Console.Clear();
        }

        public void altaCliente()
        {
            string nombre, mail;
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente.");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el mail del cliente.");
            mail = Console.ReadLine();
            Clientes.Add(new Cliente(nombre, mail));
        }
        public void getProyectos(char tipo)
        {
            Console.Clear();
            foreach(Proyecto p in Proyectos){
                if (tipo == p.Tipo)
                {
                    Console.WriteLine("Proyecto: ", p.COD_PRO);
                    switch (p.Etapa)
                    {
                        case 'P':
                            Console.WriteLine("Etapa: Preventa");
                            break;
                        case 'O':
                            Console.WriteLine("Etapa: Obra");
                            break;
                        case 'T':
                            Console.WriteLine("Etapa: Terminado");
                            break;
                    }
                    switch (p.Tipo)
                    {
                        case 'C':
                            Console.WriteLine("TIpo: Casa");
                            break;
                        case 'D':
                            Console.WriteLine("TIpo: Departamento");
                            break;
                        case 'O':
                            Console.WriteLine("TIpo: Oficina");
                            break;
                        case 'L':
                            Console.WriteLine("TIpo: Lote");
                            break;
                    }
                    foreach (Ciudad c in Ciudades)
                    {
                        if (p.COD_Ciudad == c.COD_Ciudad)
                        {
                            Console.WriteLine("Ciudad: ", c.Nombre);
                            break;
                        }
                    }
                    foreach (Empresa e in Empresas)
                    {
                        if (p.COD_EMP == e.COD_EMP)
                        {
                            Console.WriteLine("Empresa: ", e.Nombre);
                            break;
                        }
                    }
                }
            }
        }
    }
}
