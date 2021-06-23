using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            bool pass=false;
            string cod_emp, nombre, direccion, mail, cod_ciudad;
            uint telefono=0;
            Console.Clear();
            Console.WriteLine("Ingrese el codigo de la empresa.");
            cod_emp = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la empresa.");
            nombre = Console.ReadLine();
            do
            {
                Console.WriteLine("Ingrese la direccion de la empresa.");
                direccion = Console.ReadLine();
                if (!Regex.Match(direccion, "^([a-zA-Z]+|[a-zA-Z]+\\s[a-zA-Z]+)+\\s+([0-9])+$").Success) //CHEQUEA LA EXPRESION REGULAR DE UNA DIRECCION VALIDA
                {
                    Console.WriteLine("El email ingresado no es valido");
                    pass = true;
                }
            } while (!pass);
            pass = false;
            do {
                Console.WriteLine("Ingrese el mail de la empresa.");
                mail = Console.ReadLine();
                if (!Regex.Match(mail, "^((\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)\\s*[,]{0,1}\\s*)+$").Success) //CHEQUEA LA EXPRESION REGULAR DE UN EMAIL VALIDO
                {
                    Console.WriteLine("El email ingresado no es valido");
                    pass = true; 
                }
            } while (!pass);
            pass = false;
            Console.WriteLine("Ingrese el telefono de la empresa.");
            try
            {
                telefono = Convert.ToUInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Debe ingresar un telefono valido (numero entero positivo, sin espacios ni numero de area)");
            }
            do
            {
                Console.WriteLine("Ingrese el codigo de la ciudad.");
                cod_ciudad = Console.ReadLine();
                foreach (Ciudad c in Ciudades) //BUSCA SI EL CODIGO DE CIUDAD EXISTE EN LA LISTA DE CIUDADES
                {
                    if (cod_ciudad == c.COD_Ciudad)
                    {
                        pass = true;
                        break;
                    }
                }
                if (pass) Console.WriteLine("Esa ciudad no existe");
            } while (!pass);
            Empresas.Add(new Empresa(cod_emp, nombre, direccion, mail, telefono, cod_ciudad));
            Console.WriteLine("Empresa añadida exitosamente, pulse cualquier tecla para volver al menu anterior.");
            Console.ReadKey();
        }

        public void altaCiudad()
        {
            bool pass=false;
            string cod_ciudad, nombre;
            Console.Clear();
            do
            {
                Console.WriteLine("Ingrese el codigo de la ciudad.");
                cod_ciudad = Console.ReadLine();
                if (cod_ciudad.Length <= 3)//VERIFICA QUE EL CODIGO DE CIUDAD NO SEA MAYOR A 3 CARACTERES
                {
                    Console.WriteLine("El codigo debe tener como maximo 3 caracteres");
                    pass = true;
                }
            } while (!pass);
            pass = false;
            do {
                Console.WriteLine("Ingrese el nombre de la ciudad.");
                nombre = Console.ReadLine();
                if (!Regex.Match(nombre, "^([a-zA-Z]+|[a-zA-Z]+\\s[a-zA-Z]+)$").Success) //CHEQUEA LA EXPRESION REGULAR DE UN NOMBRE VALIDO
                {
                    Console.WriteLine("Ese nombre no es valido!");
                    pass = true;
                }
            } while (!pass);
            Ciudades.Add(new Ciudad(cod_ciudad, nombre));
            Console.WriteLine("Ciudad añadida exitosamente, pulse cualquier tecla para volver al menu anterior.");
            Console.ReadKey();
        }

        public void altaProyecto()
        {
            string cod_pro, cod_emp, cod_ciudad;
            char etapa, tipo;
            bool pass = false;
            Console.Clear();
            Console.WriteLine("Ingrese el codigo del proyecto.");
            cod_pro = Console.ReadLine();
            do
            {
                Console.WriteLine("Ingrese el codigo de la empresa.");
                cod_emp = Console.ReadLine();
                foreach (Empresa e in Empresas) //BUSCA SI EL CODIGO DE EMPRESA EXISTE EN LA LISTA DE EMPRESAS
                {
                    if (cod_emp == e.COD_EMP)
                    {
                        pass = true;
                        break;
                    }
                }
                if (pass) Console.WriteLine("Esa empresa no existe");
            } while (!pass);
            pass = false;
            do
            {
                Console.WriteLine("Ingrese la etapa del proyecto.\nP. Preventa\nO. Obra\nT. Terminado");
                etapa = Convert.ToChar(Console.ReadLine());
            } while (etapa != 'P' && etapa != 'O' && etapa != 'T');
            do
            {
                Console.WriteLine("Ingrese el tipo de proyecto.\nC. Casa\nD. Departamento\nO. Oficina\nL. Lotes");
                tipo = Convert.ToChar(Console.ReadLine());
            } while (tipo != 'C' && tipo != 'D' && tipo != 'O' && tipo != 'L');
            do
            {
                Console.WriteLine("Ingrese el codigo de la ciudad.");
                cod_ciudad = Console.ReadLine();
                foreach (Ciudad c in Ciudades) //BUSCA SI EL CODIGO DE CIUDAD EXISTE EN LA LISTA DE CIUDADES
                {
                    if(cod_ciudad == c.COD_Ciudad)
                    {
                        pass = true;
                        break;
                    }
                }
                if (pass) Console.WriteLine("Esa ciudad no existe");
            } while (!pass);
            Proyectos.Add(new Proyecto(cod_pro, cod_emp, etapa, tipo, cod_ciudad));
            Console.WriteLine("Proyecto añadido exitosamente, pulse cualquier tecla para volver al menu anterior.");
            Console.ReadKey();
        }

        public void altaProducto() //UNUSED
        {
            Console.Clear();
        }

        public void altaCliente()
        {
            string nombre, mail;
            bool pass = false;
            Console.Clear();
            do
            {
                Console.WriteLine("Ingrese el nombre de la ciudad.");
                nombre = Console.ReadLine();
                if (!Regex.Match(nombre, "^(|[a-zA-Z]+\\s[a-zA-Z]+)$").Success) //CHEQUEA LA EXPRESION REGULAR DE UN NOMBRE Y APELLIDO VALIDO
                {
                    Console.WriteLine("Ese nombre no es valido! (Debe ser nombre **Y** apellido separados por un espacio)");
                    pass = true;
                }
            } while (!pass);
            do
            {
                Console.WriteLine("Ingrese el mail de la empresa.");
                mail = Console.ReadLine();
                if (!Regex.Match(mail, "^((\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)\\s*[,]{0,1}\\s*)+$").Success) //CHEQUEA LA EXPRESION REGULAR DE UN EMAIL VALIDO
                {
                    Console.WriteLine("El email ingresado no es valido");
                    pass = true;
                }
            } while (!pass);
            Clientes.Add(new Cliente(nombre, mail));
            Console.WriteLine("Cliente añadido exitosamente, pulse cualquier tecla para volver al menu anterior.");
            Console.ReadKey();
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
            Console.ReadKey();
        }
    }
}
