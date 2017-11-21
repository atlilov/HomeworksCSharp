using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {

            var meters = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());
            var miles = meters / 1609;
            var km = meters / 1000;
            var allInSeconds = (hours * 60) * 60 + minutes * 60 + seconds;
            var allInHours = (seconds / 60) / 60 + minutes / 60 + hours;

           Console.WriteLine(meters/allInSeconds);
           Console.WriteLine(km/allInHours);
           Console.WriteLine(miles/allInHours);


        }
    }
}
