using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            double avg;

            Console.WriteLine("The program read 10 numbers and calculates the average of this numbers.");

            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            

            avg = Convert.ToDouble(sum / (i-1)); // how it is possible to print the result in the decimal form ?

            Console.WriteLine("The sum of 10 no is : {0} \nThe Average is : {1}\n", sum, avg);

            Console.ReadKey();

        }
    }
}
