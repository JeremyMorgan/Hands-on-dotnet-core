using System;

namespace csvreader
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("values.csv"); 

            int counter = 0;
            string line; 

            while((line = file.ReadLine()) != null)
            {                
                counter++;
            }

            Console.WriteLine("There are {0} lines in this file", counter);
            file.Close(); 
        }
    }
}
