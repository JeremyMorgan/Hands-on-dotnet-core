using System;
using System.IO;

namespace csvreader
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "values.csv";

            if (File.Exists(fileName))
            {
                 System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                 int counter = 0;
                 string line;

                while((line = file.ReadLine()) != null)
                {
                    counter++;
                }

                Console.WriteLine("There are {0} lines in this file", counter);

                file.Close();
            }else {
                Console.WriteLine("Error: The file {0} could not be found", fileName);
            }
        }
    }
}
