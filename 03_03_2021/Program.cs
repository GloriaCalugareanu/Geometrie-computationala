using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_03_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            produsScalar();
            //problemaDoi();
        }

        private static void problemaDoi(double a, double b, double c)
        {
            if (a == 0)
                Console.Write("");
            else Console.Write($"{a}i");
            if (b < 0)
                Console.Write($"{b}j");
            else if (b == 0)
                Console.Write("");
            else
                Console.Write($"+{b}j");
            if (c < 0)
                Console.Write($"{c}z");
            else if (c == 0)
                Console.Write("");
            else
                Console.Write($"{c}z");

            Console.WriteLine();
            Console.ReadKey();

        }

        private static void produsScalar()
        {
            double x1, y1, z1, x2, y2, z2, s1, s2;
            Console.Write("Valoarea lui x1= ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("Valoarea lui y1= ");
            y1 = double.Parse(Console.ReadLine());
            Console.Write("Valoarea lui z1= ");
            z1 = double.Parse(Console.ReadLine());
            Console.Write("Valoarea lui x2= ");
            x2 = double.Parse(Console.ReadLine());
            Console.Write("Valoarea lui y2= ");
            y2 = double.Parse(Console.ReadLine());
            Console.Write("Valoarea lui z2= ");
            z2 = double.Parse(Console.ReadLine());


            Console.Write("v1= " + x1 + "*i");
            if (y1 < 0)
                Console.Write(y1 + "*j");
            else
                Console.Write("+ " + y1 + "*j");
            if (z1 < 0)
                Console.Write(z1 + "k");
            else
                Console.Write("+" + z1 + "k");
            Console.WriteLine();
            Console.Write("v1= " + x1 + "*i");
            if (y2 < 0)
                Console.Write(y2 + "*j");
            else
                Console.Write("+ " + y2 + "*j");
            if (z2 < 0)
                Console.Write(z2 + "k");
            else
                Console.Write("+" + z2 + "k");

            double proScal = x1 * x2 + y1 + y2 + z1 * z2;
            Console.WriteLine("Produsul scalar al vectorului este=" + proScal);

            if (proScal == 0)
                Console.WriteLine("Vectorii sunt perpendiculari");
            else
                Console.WriteLine("Vectorii nu sunt perpendiculari");

            s1 = Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
            s2= Math.Sqrt(x2 * x2 + y2 + y2 + z2 * z2);

            Console.WriteLine($"Marimea vectorului 1 este{s1}");
            Console.WriteLine($"Marimea vectorului 2 este{s2}");
            Console.ReadKey();

        }
    }
}
