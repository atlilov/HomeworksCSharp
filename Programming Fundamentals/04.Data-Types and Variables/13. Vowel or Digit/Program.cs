using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char str = char.Parse(Console.ReadLine());
            if (str == 'a' || str==  'o' ||str =='e' || str == 'i' ||str =='u' ||str=='y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(str))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            } 
            
        }
    }
}
