using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_2_OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo;

            Console.WriteLine("Please insert a number");
            chislo = int.Parse(Console.ReadLine());

            if (chislo % 2 == 0)
            {
                Console.WriteLine("Chetno e!");
            }
            else
            {
                Console.WriteLine("Nechetno e!");
            }
            Console.ReadKey(true);
        }
    }
}
