using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase1;


namespace clase1
{
   public class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("si desea multiplicar dos numeros presione 1 ");
            Console.WriteLine("si desea dividir dos numeros presione 2 ");
            Console.WriteLine("si desea capturar 5 nombres de alumnos presione 3 ");
            Console.WriteLine("si desea capturar las edades de 5 alumnos presione 4 ");
            opcion=int.Parse(Console.ReadLine());
            class1 c1 = new class1();
            class2 c2 = new class2();
            class3 c3 = new class3();
            class4 c4 = new class4();

            if (opcion==1)
            {
                c1.multiplicar();
            }
            else
            {
                if (opcion == 2)
                {
                    c2.divi();
                }
                else
                {
                    if (opcion == 3)
                    {
                        c3.nombres();
                    }
                    else
                    {
                        if (opcion==4)
                        {
                            c4.ed();
                        }
 
                    }
                }
            }
            

            

        }
    }
}
