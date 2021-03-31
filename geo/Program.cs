using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //produsScalar();
            //problemaDoi();
            problemTrei();
        }

        private static void problemTrei()
        {
            double x1, y1, z1, x2, y2, z2, x3, y3, z3;
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
            Console.Write("Valoarea lui x3= ");
            double i= int.Parse(Console.ReadLine());
            Console.Write("Valoarea lui y3= ");
            double j= int.Parse(Console.ReadLine());
            Console.Write("Valoarea lui z3= ");
           double k= int.Parse(Console.ReadLine());

            

            double produs_mixt = x1 * y2 * k + x2 * j * z1 + i * y1 * z2 - z1 * y2 * i - z2 * j * x1 - k;
            double volum = Math.Abs(produs_mixt);


            if (produs_mixt == 0)
            {
                Console.WriteLine("produsul mixt=" + produs_mixt);
                Console.Write("volum=0");
                Console.WriteLine("sunt complanari");

            }
            else
            {
                Console.WriteLine("produs mixt mixt=" + produs_mixt);
                Console.WriteLine("volum=" + volum);
                Console.WriteLine("nu sunt coplanari");
            }
            Console.ReadKey();
               
        }
        

        private static void problemaDoi()
        {
            double x1, y1, z1, x2, y2, z2;
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

            double i = (y1 * z2) - (z1 * y2);
            double j = (z1 * x2) - (x1 * z2);
            double k = (x1 * y2) - (x2 * y1);

                Console.WriteLine($"v1xv2={i}i{j}j+{k}k");
            
            if (j < 0 && k < 0)
           

                Console.WriteLine($"v1xv2=0");
           
            if (i == 0 && j == 0 && k == 0)

                Console.WriteLine("Sunt Coliniari");
            else
                Console.WriteLine("Nu sunt coliniari");
                double aria = Math.Sqrt((i * i) + (j * j) + (k * k));
                Console.WriteLine($"Aria={aria}");
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
                Console.Write(z1 + "*k");
            else
                Console.Write("+" + z1 + "*k");
            Console.WriteLine();
            Console.Write("v1= " + x2 + "*i");
            if (y2 < 0)
                Console.Write(y2 + "*j");
            else
                Console.Write("+ " + y2 + "*j");
            if (z2 < 0)
                Console.Write(z2 + "*k");
            else
                Console.Write("+" + z2 + "*k");

            double proScal = x1 * x2 + y1 * y2 + z1 * z2;
            Console.WriteLine("Produsul scalar al vectorului este=" + proScal);

            if (proScal == 0)
                Console.WriteLine("Vectorii sunt perpendiculari");
            else
                Console.WriteLine("Vectorii nu sunt perpendiculari");

            s1 = Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
            s2 = Math.Sqrt(x2 * x2 + y2 * y2 + z2 * z2);

            Console.WriteLine($"Marimea vectorului 1 este{s1}");
            Console.WriteLine($"Marimea vectorului 2 este{s2}");
            Console.ReadKey();


        }
    }
}
