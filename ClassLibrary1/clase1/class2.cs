using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase1
{
    class class2
    {
        int a, b, divis;
        public void divi()
        {

            Console.WriteLine("digite el primer numero entero ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el segundo numero entero ");
            b = int.Parse(Console.ReadLine());
            if (b==0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero. ");
                Console.ReadKey();
            }
            else
            {
                divis = a / b;
                Console.WriteLine("El resultado de "+a+" dividido entre "+b+" es: "+divis);
                Console.ReadKey();
            }
        }
    
    }
}
