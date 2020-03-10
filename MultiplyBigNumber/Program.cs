using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            string result = string.Empty;
            int currentAddition = 0;

            for (int i = num1.Length-1; i >= 0; i--)
            {
                int sum = int.Parse(num1[i].ToString()) * num2 + currentAddition;
                if(sum > 9 && i != 0)
                {
                    result = (sum % 10)+ result;
                    currentAddition = sum / 10;
                }
                else
                {
                    currentAddition = 0;
                    result = sum + result;
                }
            }
            Console.WriteLine(result);
        }
    }
}
