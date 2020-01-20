using System;
using System.Collections.Generic;


namespace Class2Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            string charCount = "Vvorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. " +
                "Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, " +
                "non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. " +
                "Donec nec velit non ligula efficitur luctus." ;
            Dictionary<char,int> dict = new Dictionary<char, int>();
            
            for (int index = 0; index < charCount.Length; index++)
            {
                char theKey = charCount[index];
                if (!dict.ContainsKey(theKey))
                    dict.Add(theKey, 1);
                else
                    dict[charCount[index]]++;
            }
            foreach(var key in dict.Keys)
            {
                Console.WriteLine("{0}: {1}", key, dict[key]);
            }
            {

            }

            Console.ReadLine();


        }
    }
}
