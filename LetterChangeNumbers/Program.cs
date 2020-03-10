using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);


            decimal result = 0m;
            for (int i = 0; i < line.Length; i++)
            {
                char firstCharacter = line[i][0];
                char secondCharacter = line[i][line[i].Length - 1];
            }
        }
    }
}
