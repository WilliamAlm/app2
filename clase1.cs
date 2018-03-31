using System;

namespace SSTI
{
    class clase1
    {
        public void parimpar()
        {
            //Saber cual es el numero mayor_
            
            Console.WriteLine("Bienvenido para saber el numero mayor");
            double num1,num2;
            Console.Write("Digite primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            if (num1 > num2)
            {
                Console.Write("El numero 1: {0} es mayor", num1);
            }
            else
            {
                Console.Write("El numero 2: {0} es mayor", num2);
            }
            Console.ReadKey();
        }
    }
}