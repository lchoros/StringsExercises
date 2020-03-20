using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int primeCounter = 0;
            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    primeCounter++;
                }
            }
            int lastPrime = 0;
            for (int i = 0; i < primeCounter; i++)
            {
                int counter = 1;
                while (true)
                {
                    if (IsPrime(counter))
                    {
                        Console.Write("1");
                        if(counter > lastPrime)
                        {
                            lastPrime = counter;
                            counter++;
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("0");
                    }
                    counter++;
                }
                Console.WriteLine();
            }
        }

        public static bool IsPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
