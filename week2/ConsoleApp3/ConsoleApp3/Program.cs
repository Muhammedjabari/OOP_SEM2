using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        // Function to check perfect square
        static bool isSquare(int n)
        {
            int sr = (int)Math.Sqrt(n);

            return (sr * sr == n);
        }
        static void printPrimeAndFib(int n)
        {
            bool[] prime = new bool[n + 1];


            for (int p = 0; p <= n; p++)
                prime[p] = true;

            for (int p = 2; p * p <= n; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * 2; i <= n; i += p)
                        prime[i] = false;
                }
            }

        }
    }
}
