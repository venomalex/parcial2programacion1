using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase1
{
    class class1
    {
        int a, b, multi;
        public void multiplicar()
        {

            Console.WriteLine("digite el primer numero entero ");
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Todo numero multiplicado por cero el resultado es cero");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("digite el segundo numero entero a multiplicar ");
                b = int.Parse(Console.ReadLine());
                multi = a * b;
                Console.WriteLine("El resultado de la multiplicacion es: "+multi);
                Console.ReadKey();
            }
        }
    }
}
