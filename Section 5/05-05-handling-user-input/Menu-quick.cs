using System;

namespace jonny5
{
    class Program
    {
        static void Main(string[] args)
        {
                       Console.WriteLine("Choose an option:" );
            Console.WriteLine("1. Change to Blue" );
            Console.WriteLine("2. Change to Red" );
            Console.WriteLine("3. Change to Green" );
            Console.WriteLine("4. Exit" );

            int response = Convert.ToInt16(Console.ReadLine());

            switch(response){
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Menu is now blue\n");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Menu is now red\n");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Menu is now green\n");
                    break;
                case 4:
                    Console.WriteLine("Exiting program");
                    break;
                default:
                    Console.WriteLine("Please select option 1-4\n");
                    break;
            }
        }          
    }
}
