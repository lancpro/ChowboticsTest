/*4.	Write the necessary function here
void test()
{
    int a = 10;
    int b = 20;
    // call a function here
    Console.Write($"a = {a} and b = {b} and c = {c}");
    // which should print a = 20 and b = 10 and c = 200
    // c is the product of a and b
}
*/

using System;

namespace SwapAndMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadKey();
        }


        private static void Test()
        {
            int a = 10;
            int b = 20;
            // call a function here
            int c = SwapAndMultiply(ref a, ref b);
            Console.Write($"a = {a} and b = {b} and c = {c}");
            // which should print a = 20 and b = 10 and c = 200
            // c is the product of a and b
        }

        private static int SwapAndMultiply(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
            return a * b;
        }
    }
}