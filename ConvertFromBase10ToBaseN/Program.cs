using System;
using System.Linq;

namespace ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int baseNum = input[0];
            int numsToConvert = input[1];

            string result = string.Empty;

            while (numsToConvert > 0)
            {
                var remainder = numsToConvert % baseNum;
                result = remainder.ToString() + result;
                numsToConvert /= baseNum;
            }

            Console.WriteLine(result);
        }
    }
}
