using System;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine().Split().ToArray();
            var firstStr = inputLine[0];
            var secondStr = inputLine[1];
            Console.WriteLine(CalcSumOfCharacters(firstStr, secondStr));
        }

        public static int CalcSumOfCharacters(string first, string second)
        {
            int maxLength = Math.Max(first.Length, second.Length);
            int totalSum = 0;

            for (int i = 0; i < maxLength; i++)
            {
                int num1 = first.Length > i ? first[i] : 1;
                int num2 = second.Length > i ? second[i] : 1;
                totalSum += (num1 * num2);
            }

            return totalSum;
        }
    }
}
