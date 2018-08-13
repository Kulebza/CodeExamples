using System;
using System.Collections.Generic;
using System.Linq;

namespace StringDictionaryTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write string line:");
            string inputLine = Console.ReadLine();
            var cleanLine = inputLine.Where(ch => ch <= 127 && char.IsLetter(ch)).ToArray().ToArray(); //перенос в новую строку символов латиницы из введенной строки
            Array.Sort(cleanLine); 
            Dictionary<char, int> letterDictionary = new Dictionary<char, int>();
            foreach (var letter in cleanLine)
                {
                if (!letterDictionary.ContainsKey(letter))
                    letterDictionary.Add(letter, 1);
                else
                    letterDictionary[letter] += 1;               
            }
            Console.WriteLine("{0} {1,5}\n", "Letter", "Count");
            foreach (var letter in letterDictionary)
            {
                Console.WriteLine("{0} {1,5:D}", letter.Key, letter.Value);
            }
            Console.ReadKey();
        }
    }
}
