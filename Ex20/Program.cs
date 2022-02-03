using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20
{
    internal class Program
    {
        private static void ProdusMixt()
        {
            double x1, y1, z1, x2, y2, z2, x3, y3, z3, prodmixt;
            Console.WriteLine("V1 coordinates:");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            z1 = double.Parse(Console.ReadLine());
            Console.WriteLine("V2 coordinates:");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            z2 = double.Parse(Console.ReadLine());
            Console.WriteLine("V3 coordinates:");
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            z3 = double.Parse(Console.ReadLine());
            prodmixt = (x1 * y2 * z3) + (x2 * y3 * z1) + (x3 * y1 * z2) - (x3 * y2 * z1) - (x1 * y3 * z2) - (x2 * y1 * z3);
            Console.WriteLine($"Mixt product of vectors:{prodmixt}");
            if (prodmixt == 0)
            {
                Console.WriteLine("Sunt coplanari");
            }
            else
            {
                Console.WriteLine("Nu sunt coplanari");
            }
            Console.WriteLine($"Paralelipiped volume:{Math.Sqrt(Math.Pow(prodmixt, 2))}");
        }

        static void Main(string[] args)
        {
            ProdusMixt();
        }
    }
}
