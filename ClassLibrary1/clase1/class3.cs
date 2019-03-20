using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase1
{
    class class3
    {
        int i;
        string n;
        public void nombres()
        {
            for (i=1; i<=5;i++) 
            {

                Console.WriteLine("digite el nombre del alumno numero "+i);
                n = Console.ReadLine();
                Console.WriteLine("el nombre ingresado del estudiante " + i+ "es: "+n);

            }
            Console.ReadKey();
        }
    }
}
