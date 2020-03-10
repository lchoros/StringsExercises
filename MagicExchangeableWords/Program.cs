using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            string word1 = words[0];
            string word2 = words[1];
            bool IsExchangeable = true;
            if (word1.Length == word2.Length)
            {
                int w = word1[0];
                int y = word2[0];
                int difference = word1[0] - word2[0];
                for (int i = 1; i < word1.Length; i++)
                {
                    if (difference != (word1[i] - word2[i]))
                    {
                        IsExchangeable = false;
                    }
                }
            }
            else
            {
                IsExchangeable = false;
            }
            Console.WriteLine(IsExchangeable);

        }
    }
}
