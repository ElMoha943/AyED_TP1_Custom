using System;
using System.Collections.Generic;

namespace AyED_TP1
{
    class Program
    {
        static void Main()
        {
            //VARIABLES
            const string empress_key = "OWO"; //A - CLAVES CONSTANTE
            string clave = ""; //Clave que ingresa el usuario
            char option = 's';
            int attempts = 3, repeat;

            string cod_emp, nombre, direccion, mail, cod_ciudad;
            long telefono;

            List<Empresa> Empresas = new();
            Ciudad Rosario = new("Rosario", "ROS");
            Ciudad Cordoba = new("Cordoba", "CBA");
            Ciudad BSAS = new("Buenos Aires", "BA");

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
                        Console.WriteLine("\nIngrese la clave, " + attempts + " intentos restantes.");
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
                while (clave != empress_key); //VALIDACION DE CLAVE
                //MENU DE EMPRESA (CLAVE ACEPTADA)
                do
                {
                    Console.Clear();
                    Console.WriteLine("MENU EMPRESAS DESARROLLADORAS :\n\n1. Alta de EMPRESAS \n2. .\n3. .\n0. Volver al menú principal");
                    do
                    {
                        option = Console.ReadKey().KeyChar; //INGRESO DE DATO DEL MENU CON ESTRUCTURA DE CONTROL
                    } while (option != '1' && option != '2' && option != '3' && option != '4');
                    switch (option)
                    {
                        case '1': //ALTA DE EMPRESAS
                            do
                            {
                                Console.Clear();
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
                            } while (repeat == '1'); //REPITE LA ENTRADA DE EMPRESAS
                            break;

                        case '2': //...
                            Console.Clear();
                            foreach (Empresa aEmpresa in Empresas) //CUENTA LA CANTIDAD DE EMPRESAS POR CIUDAD
                            {
                                switch (aEmpresa.Cod_ciudad)
                                {
                                    case "ROS":
                                        Rosario.CantEmpresas++;
                                        break;

                                    case "CBA":
                                        Cordoba.CantEmpresas++;
                                        break;

                                    case "BA":
                                        BSAS.CantEmpresas++;
                                        break;
                                }
                            }
                            Console.Clear();
                            Console.WriteLine("\nRosario: " + Rosario.CantEmpresas + "\nCordoba: " + Cordoba.CantEmpresas + "\nBuenos Aires: " + BSAS.CantEmpresas + "\n\nPulse cualquier tecla para continuar");
                            mayorCiudad(Cordoba.CantEmpresas, Rosario.CantEmpresas, BSAS.CantEmpresas);
                            Console.ReadLine();
                            break;

                        case '3': //...

                            break;

                    }
                } while (option != 0);
                attempts = 3;
                option = 's';
            }
        }

        static void mayorCiudad(int CantCBA, int CantRos, int CantBA)
        {
            if (CantRos != CantCBA && CantRos != CantBA && CantCBA != CantBA)
            { // todos distintos
                if (CantRos > CantCBA && CantRos > CantBA) Console.WriteLine("Rosario es la ciudad con mas empresas");
                else if (CantCBA > CantBA && CantCBA > CantRos) Console.WriteLine("Cordoba es la ciudad con mas empresas");
                else Console.WriteLine("Buenos Aires es la ciudad con mas empresas");
            }
            else if (CantRos == CantCBA && CantRos == CantBA) Console.WriteLine("Las 3 ciudades tienen la misma cantidad de empresas");
            else
            {//2 iguales
                if (CantRos == CantCBA)
                {
                    if (CantRos > CantBA) Console.WriteLine("Rosario y Cordoba tienen la mayor cantidad de empresas");
                    else Console.WriteLine("Buenos Aires tiene la mayor cantidad de empresas");
                }
                else if (CantCBA == CantBA)
                {
                    if (CantRos > CantCBA) Console.WriteLine("Rosario es la ciudad con mas empresas");
                    else Console.WriteLine("Cordoba y Buenos Aires tienen la mayor cantidad de empresas");
                }
                else
                {
                    if (CantCBA > CantBA) Console.WriteLine("Cordoba es la ciudad con mas empresas");
                    else Console.WriteLine("Rosario y Buenos Aires tienen la mayor cantidad de empresas");
                }
            }
        }
    }
}