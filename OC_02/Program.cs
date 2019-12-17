using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace OC_02
{
    class Program
    {
        static void Main(string[] args)
       
        {
            Console.WriteLine("Print the first 100 Fibonaccinumbers");
            Console.WriteLine();

            for (int i = 1; i < 101; i++)
            {
                BigInteger fib = Fibonacci_Iterative(i);
                Console.WriteLine(fib);
            }

                Console.ReadKey();
        }
       private static BigInteger Fibonacci_Iterative(int n)
        {
            BigInteger fn_1 = 1;
            BigInteger fn_2 = 1;

            for (int i = 3; i <= n; i++ )
            {
                BigInteger fn_2Aux = fn_1;
                fn_1 = fn_2 + fn_1;
                fn_2 = fn_2Aux;
            }
            return fn_1;
        }
    }
}
