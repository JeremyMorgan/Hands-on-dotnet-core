using System;

namespace jonny5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Well {0} is a great name", name);
        }
    }
}
