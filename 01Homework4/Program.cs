using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxVlue = 100;

            Console.WriteLine("Program will print every prime number from 1 to 100");

            int maxNumber = 100;

            for (int i = 2; i < maxNumber; i++)
            {

                if ((i % 2 == 0 && i != 2) || i % 3 == 0 && i != 3 || i % 4 == 0 && i != 4 || i % 5 == 0 && i != 5 || i % 7 == 0 && i != 7)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("{0} is prime number", i);
                }
            }

            Console.ReadKey();
        }
        // https://www.sanfoundry.com/csharp-program-prime-numbers/?fbclid=IwAR3lTyfvaySmAnUscxiz2sTVDTMBWArM17DYFQexQHr3nnvrABEsI7-ec9g
        // I have found this solution on website but this code looks inefficient for me to place the code in to two nested loops ? What is better ?
    }
}

