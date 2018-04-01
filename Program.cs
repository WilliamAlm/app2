using System;

namespace SSTI
{
    class Program
    {
        static void Main()
        {
            clase1 cl1 = new clase1();
            clase2 cl2 = new clase2();
            int m;
            Console.WriteLine("Practica 1");
            Console.WriteLine("1 - Numero mayor, 2 - Inicio de Sesion, 3 - Numero par o Impar, 4 - Calculadora");
            m = Convert.ToInt16(Console.ReadLine());
            switch (m)
            {
                case 1:
                    cl1.parimpar();
                break;
                case 2:
                    cl2.login();
                break;
                case 3:
                case 4:
                break;
                
            }
        }
    }
}
