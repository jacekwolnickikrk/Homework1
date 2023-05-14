using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter fisrt integer x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter fisrt integer y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
                Console.WriteLine("x is greater than y");
            else Console.WriteLine("y is greater than x");

            Console.ReadKey();

        }
    }
}
