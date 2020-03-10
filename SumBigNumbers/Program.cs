using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            var maxLen = Math.Max(num1.Length, num2.Length);

            num1 = num1.PadLeft(maxLen + 1, '0');
            num2 = num2.PadLeft(maxLen + 1, '0');

            int length = num1.Length;
            int currentSum = 0;
            var firstDigits = num1.Select(x => int.Parse(x.ToString())).ToArray();
            var secondDigits = num1.Select(x => int.Parse(x.ToString())).ToArray();
            var sum = new int[num1.Length];
            for (int i = length - 1; i >= 0; i--)
            {
                int digitOne = firstDigits[i];
                int digitTwo = secondDigits[i];

                int total = digitOne + digitTwo + currentSum;
                sum[i] = total % 10;


                if (total > 9)
                {
                    currentSum = 1;
                }
                else
                {
                    currentSum = 0;
                }
            }
            Console.WriteLine(string.Join("", sum));
        }
    }
}
