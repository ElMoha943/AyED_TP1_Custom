using System;
using System.Collections.Generic;

namespace AyED_TP1
{
    class Program
    {
        static void Main()
        {
            Login l = new();
            Show s = new();
            int option = -1;
            char menu='0';

            do
            {
                //MENU PRINCIPAL
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL:\n\n1. Empresas\n2. Clientes\n0. Salir");
                do
                {
                    option = Console.ReadKey().KeyChar;
                } while (option != '1' && option != '2' && option != '0');

                //LOGIN
                switch (option)
                {
                    case '1':
                        menu = l.login("cliente");
                        break;
                    case '2':
                        menu = l.login("empresa");
                        break;
                }

                //MOSTRAR SUB MENUS
                switch (menu)
                {
                    case '1':
                        s.showCliente();
                        break;
                    case '2':
                        s.showEmpresa();
                        break;
                }
            } while (option != '0');
        }
    }
}