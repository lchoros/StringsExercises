using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrookedDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string number = new string(input.Where(c => char.IsDigit(c)).ToArray());
            while (true)
            {
                int result = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    var z = number[i];
                    result += int.Parse(number[i].ToString());
                }
                if(result > 9)
                {
                    number = result.ToString();
                }
                else
                {
                    Console.WriteLine(result);
                    break;
                }
            }
        }
    }
}
