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
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("{0} is a neat age {1}", age, name);
        }
    }
}
