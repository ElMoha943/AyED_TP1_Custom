using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyED_TP1
{
    public class Login
    {
        public char login(string tipo)
        {
            uint attempts = 3;
            string clave, secret = "admin123";
            while (attempts > 0) {
                Console.WriteLine("\nIngrese la clave, " + attempts + " intentos restantes.");
                attempts--; //DISMINUYE EL CONTADOR DE INTENTOS
                clave = Console.ReadLine(); //INGRESO DE DATOS
                if (clave == secret) {
                    if (tipo == "cliente") return '1';
                    if (tipo == "empresa") return '2';
                }
                else Console.WriteLine("Clave incorrecta.");
            }
            Console.WriteLine("Se agotaron los intentos."); //MENSAJE DE ERROR DESPUES DE FALLAR 3 VECES
            return '0';
        }
    }
}
