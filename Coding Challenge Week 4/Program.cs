using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Coding_Challenge_Week_4
{
    class Program
    {

        static readonly double GoldenRatio = (1 + Math.Sqrt(5)) / 2;
        static readonly double ReciprocalGoldenRatio = (1 - Math.Sqrt(5)) / 2;

        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(ClosedFormFibonacci(n));
            Console.WriteLine(RecursiveFibonacci(n));
            Console.WriteLine(IterativeFibonacci(n));
            Console.ReadLine();

        }

        static ulong ClosedFormFibonacci(int n)
        {
            return (ulong)((Math.Pow(GoldenRatio, n) - Math.Pow(ReciprocalGoldenRatio, n)) / Math.Sqrt(5));
        }

        static ulong RecursiveFibonacci(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        static ulong IterativeFibonacci(int n)
        {
            ulong a = 0;
            ulong b = 1;
            ulong c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
