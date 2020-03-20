using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string pattern = "";
            var reg = new Regex(pattern);
            while (line != "end")
            {
                Console.WriteLine(reg.Replace(line, pattern));
            }
        }
    }
}
