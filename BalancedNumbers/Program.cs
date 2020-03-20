using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (true && n > 99 & n < 1000)
            {
                string num = n.ToString();
                if (int.Parse(num[0].ToString()) + int.Parse(num[2].ToString()) != int.Parse(num[1].ToString()))
                {
                    break;
                }
                sum += n;
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
