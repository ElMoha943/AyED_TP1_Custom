using System;
using System.Collections.Generic;

namespace AyED_TP1
{
    class Program
    {
        static void Main()
        {
            //VARIABLES
            const string empress_key = "OWO"; //A - CLAVES
            char option;
            string clave="";
            int attempts=3, repeat;

            string cod_emp;
            string nombre;
            string direccion;
            string mail;
            long telefono;
            string cod_ciudad;

            //B - MENU
            Console.WriteLine("MENU PRINCIPAL:\n\n1. Empresas\n2. Clientes");
            do
            {
                option = Console.ReadKey().KeyChar; //INGRESO DE DATO DEL MENU CON ESTRUCTURA DE CONTROL
            } while (option != '1' && option != '2');

            // C - CLIENTES
            if (option == '2')
            {
                Console.WriteLine("‘Programa en Proceso.");
            }
            else
            {
                //D - EMPRESAS
                do
                {
                    Console.Clear();
                    if (attempts > 0)
                    {
                        Console.WriteLine("\nIngrese la clave, "+attempts+" intentos restantes.");
                        clave = Console.ReadLine(); //INGRESO DE DATOS
                        attempts--; //CONTADOR DE INTENTOS
                    }
                    else
                    {
                        Console.WriteLine("Clave incorrecta."); //MENSAJE DE ERROR DESPUES DE FALLAR 3 VECES
                        Console.ReadKey();
                        Environment.Exit(0); //CIERRA EL PROGRAMA TRAS TOCAR UNA TECLA
                    }
                }
                while(clave!=empress_key); //VALIDACION DE CLAVE
                Console.Clear();
                //MENU DE EMPRESA (CLAVE ACEPTADA)
                do
                {
                    Console.WriteLine("MENU EMPRESAS DESARROLLADORAS :\n\n1. Alta de EMPRESAS \n2. .\n3. .\n0. Volver al menú principal");
                    do
                    {
                        option = Console.ReadKey().KeyChar; //INGRESO DE DATO DEL MENU CON ESTRUCTURA DE CONTROL
                    } while (option != '1' && option != '2' && option != '3' && option != '4');
                    List<Empresa> Empresas = new();
                
                    switch (option)

                    {
                        case '1': //ALTA DE EMPRESAS
                            do
                            {
                                Console.WriteLine("\nIngrese el codigo de la empresa");
                                cod_emp = Console.ReadLine();
                                Console.WriteLine("\nIngrese el nombre de la empresa");
                                nombre = Console.ReadLine();
                                Console.WriteLine("\nIngrese la direccion de la empresa");
                                direccion = Console.ReadLine();
                                Console.WriteLine("\nIngrese el mail de la empresa");
                                mail = Console.ReadLine();
                                Console.WriteLine("\nIngrese el telefono de la empresa");
                                telefono = Int64.Parse(Console.ReadLine());
                                Console.WriteLine("\nIngrese el codigo de ciudad de la empresa");
                                cod_ciudad = Console.ReadLine();
                                Empresas.Add(new Empresa(cod_emp, nombre, direccion, mail, telefono, cod_ciudad));
                                Console.WriteLine("\nDesea ingresar otra empresa?\n1. Si\n2. No");
                                do
                                {
                                    repeat = Console.ReadKey().KeyChar; //INGRESO DE DATO DEL MENU CON ESTRUCTURA DE CONTROL
                                } while (repeat != '1' && repeat != '2');
                            } while (repeat=='1'); //REPITE LA ENTRADA DE EMPRESAS
                            break;

                        case '2': //...
                            foreach (Empresa aEmpresa in Empresas)
                            {
                                Console.WriteLine(aEmpresa.ToString());
                            }
                            break;

                        case '3': //...

                            break;

                    }
                } while (option != 0);
            }
        }
    }
}
