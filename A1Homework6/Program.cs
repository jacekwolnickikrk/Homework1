using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1Homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter 'n' elements of Fibonacci sequence: ");
            int nNumber = Convert.ToInt32(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;
            int n3;

            for (int i = 0; i == nNumber && nNumber == 0;) ;
            Console.WriteLine(string.Format("Elements of Fibonacci sequence: {0}", n1 ));

            for (int i = 1; i == nNumber && nNumber == 1;) ;
            Console.WriteLine(string.Format("Elements of Fibonacci sequence: {0}", n2));


            for (int i = 2; i <= nNumber; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(string.Format("Elements of Fibonacci sequence: {0} + {1} ", n1, n2, +n3));

                n1 = n2;
                n2 = n3;
               
            }

            Console.ReadKey();
        }

        // How can I solve this solution into proper way ?
    }
}
