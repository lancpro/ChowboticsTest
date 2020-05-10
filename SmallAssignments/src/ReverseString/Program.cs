//Using LINQ, reverse a string

using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to br reversed");
            var reversedString = ReverseStringUsingLinq(Console.ReadLine());
            Console.WriteLine(reversedString);
            Console.ReadKey();
        }

        private static string ReverseStringUsingLinq(string message)
        {
            return new string(message.Reverse().ToArray());
        }
    }
}