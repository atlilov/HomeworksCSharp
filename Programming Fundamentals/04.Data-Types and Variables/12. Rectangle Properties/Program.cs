using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double s = a * b;
            double p = 2 * a + 2 * b;
            double diagonally = 0;
            diagonally = a * a + b * b;
            diagonally = Math.Sqrt(diagonally);
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(diagonally);

        }
    }
}
