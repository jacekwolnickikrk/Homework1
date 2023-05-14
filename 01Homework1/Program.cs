using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a positive integer:");
            int varn = Convert.ToInt32(Console.ReadLine());


            int sum = 0;
            for (int i = 2; i <= varn; i += 2)
            sum += i;


            Console.WriteLine("The sum of even numbers equals: " + sum);
           
             Console.ReadKey();



        }
    }
}
