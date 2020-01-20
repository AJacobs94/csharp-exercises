using System;
using System.Collections.Generic;

namespace ListAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWords = new List<string>() {"Aliyah", "Zach","Clair", "Fives" };
            FiveWord(myWords);
        }
        public static void FiveWord(List<string> words)
        {
            foreach (string word in words)
            {
                if (word.Length == 5)
                    Console.WriteLine(word + "");
                
            }
            Console.ReadLine();

        }
    }
}
