using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primaproblema();
            problemaDoi();
           // problemaTrei();
           // problema4();
        }

        private static void problema4()
        {
            int AB = 0, xA, xB, yA, yB, a, b, c, x = 1, y = -1;
            Console.WriteLine("Introduceti valoarea lui A");
            xA = int.Parse(Console.ReadLine());
            yA = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui B");
            xB = int.Parse(Console.ReadLine());
            yB = int.Parse(Console.ReadLine());
            Console.WriteLine("A(" + xA + ";" + yA + ")");
            Console.WriteLine("B(" + xB + ";" + yB + ")");
            c = xA * yB - xB * yA;
            a = yA - yB;
            b = xA - xB;
            if (b < 0) ;
                
        }

        private static void problemaTrei()
        {
            double a1, a2, a3, b1, b2, b3, c1, c2, c3;

            Console.WriteLine("a1=");
            a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("a2=");
            a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("a3=");
            a3 = double.Parse(Console.ReadLine());
            Console.WriteLine("b1=");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("b2=");
            b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("b3=");
            b3 = double.Parse(Console.ReadLine());
            Console.WriteLine("c1=");
            c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("c2=");
            c2 = double.Parse(Console.ReadLine());
            Console.WriteLine("c3=");
            c3 = double.Parse(Console.ReadLine());
            Console.WriteLine($"d1 : {a1}x + {b1}y + {c1} = 0");
            Console.WriteLine($"d2 : {a2}x + {b2}y + {c2} = 0");
            Console.WriteLine($"d3 : {a3}x + {b3}y + {c3} = 0");
            double det = a1 * b2 * c3 + c1 * a2 * b3 + b1 * c2 * a3 - (c1 * b2 * a3 + a1 * c2 * b3 - b1 * a2 * c3);
            if (det == 0)
            {
                Console.WriteLine("Sunt concurente");
            }
            else
            {
                Console.WriteLine("Dreptele nu sunt concurente");
            }
            Console.ReadKey();

        }
    
        private static void problemaDoi()
        {
            int AB = 0, xA, xB, yA, yB, xC, yC;
            Console.WriteLine("Introduceti valoarea lui A");


            xA = int.Parse(Console.ReadLine());
            yA = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui B");


            xB = int.Parse(Console.ReadLine());
            yB = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui C");


            xC = int.Parse(Console.ReadLine());
            yC = int.Parse(Console.ReadLine());


            if (xA * yB + xB * yC + yA * xC - (xC * -yB + xB * yA + xA * yC) == 0)
                Console.WriteLine("Punctele sunt coliniare");
            else
                Console.WriteLine("Punctele nu sunt coliniare");

            Console.ReadKey();
        }

        private static void Primaproblema()
        {
            int AB = 0, xA, xB, yA, yB, a, b, c, x = 1, y = -1;
            Console.WriteLine("Introduceti valoarea lui A");
            xA = int.Parse(Console.ReadLine());
            yA = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui B");
            xB = int.Parse(Console.ReadLine());
            yB = int.Parse(Console.ReadLine());
            Console.WriteLine("A(" + xA + ";" + yA + ")");
            Console.WriteLine("B(" + xB + ";" + yB + ")");
            c = xA * yB - xB * yA;
            a = yA - yB;
            b = xA - xB;
            x = x * a;
            y = y * b;
            Console.WriteLine("Ecuatia dreptei AB este:");
            Console.WriteLine("AB:" + x + "x+" + y + "y" + "+" + c + "=0");
            Console.ReadKey();
        }
    }
}
