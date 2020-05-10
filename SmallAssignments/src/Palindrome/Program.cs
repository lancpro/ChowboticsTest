/*
5.	What can you do to make the following work
    void func() {
        string s = "some string";
        if (s.isPalindrome()) {
            Console.Write($"{s} is a palindrome")
        }
    }
 */

using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Func("some string");
            Console.ReadKey();
        }

        private static void Func(string s)
        {
            if (s.IsPalindrome())
            {
                Console.Write($"{s} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{s} is not palindrome");
            }
        }
    }

    public static class Palindrom
    {
        public static bool IsPalindrome(this string message)
        {
            var reversedString = new string(message.Reverse().ToArray());
            return reversedString == message;
        }
    }
}
