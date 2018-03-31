using System;

namespace SSTI
{
    class clase2
    {
        public void login()
        {
            //Prueba de Login
            string user,pass;
            Console.WriteLine("Inicio de Sesion - Sistema SS");
            Console.Write("Usuario: ");
            user = Console.ReadLine();
            Console.Write("Contrasena: ");
            pass = Console.ReadLine();
            if (user == "William" && pass == "12345")
            {
                Console.Write("Bienvenido al sistema SS");
                Program m = new Program();
                //m.menu();
            }
            else
            {
                Console.WriteLine("Usuario u/o Contrasena invalido");
                Console.WriteLine("     Hasta luego");
            }
            Console.ReadKey();
        }
    }
}