using System;

namespace replacestring
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "abcdefg";

            Console.WriteLine("before replacing : " + str);

            Console.WriteLine("after replacing: " + str.Replace('f', 'z'));

        }
    }
}
