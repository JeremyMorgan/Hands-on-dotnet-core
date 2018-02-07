using System;
using stringModifier;

namespace libraryRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ChangeMyString.makeAllUppercase("Hello World!"));
            Console.WriteLine(ChangeMyString.makeReverse("Hello World!"));
        }
    }
}
