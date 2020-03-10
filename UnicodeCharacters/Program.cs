using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result = result + string.Format("\\u{0:x4}", (int)input[i]);
            }
            Console.WriteLine(result);
        }
    }
}
