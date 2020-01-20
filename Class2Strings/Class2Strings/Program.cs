using System;
using System.Collections.Generic;
using System.Linq;

namespace Class2Strings
{
    class Program
    {
        static int EvenSum(int[] integers)
        {
            int result = 0;
        foreach(int i in integers)
            if(i %2==0)
            {
                     result += i;
            };
            return result;
        }
        static void Main(string[] args)
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int result = EvenSum(integers);
            Console.WriteLine("The sum of even integers is :" + result);
            
        }
    }
}
