using System;

namespace jonny5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuClosed = false;
            Console.Clear();

            while (!menuClosed){

            Console.WriteLine("Choose an option:" );
            Console.WriteLine("1. Change to Blue" );
            Console.WriteLine("2. Change to Red" );
            Console.WriteLine("3. Change to Green" );
            Console.WriteLine("4. Exit" );

            string response = Console.ReadLine();
            int menuItemSelected;

                if (int.TryParse(response, out menuItemSelected) && (menuItemSelected > 0 && menuItemSelected < 5)){
                    Console.Clear();
                    switch(menuItemSelected){
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
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Exiting program\n");
                            menuClosed = true;
                            break;
                     }
                }else {
                    Console.Clear();
                    Console.WriteLine("Please select option 1-4\n");
                }
            }
        }
    }
}
