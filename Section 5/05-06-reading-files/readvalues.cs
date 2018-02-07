using System;
using System.Collections.Generic;
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
                //List<string> listA = new List<string>();
                
                while((line = file.ReadLine()) != null)
                {
                    string[] values = line.Split(',');
                    
                    if (counter != 0){
                        Console.WriteLine("Name: {0}", values[1]);
                        Console.WriteLine("\tID: {0}", values[0]);
                        Console.WriteLine("\tEmail: {0}", values[2]);
                        Console.WriteLine("\tStatus: {0}", values[3]);
                    }
                   counter++;
                }

                Console.WriteLine("There are {0} entries in this file", counter - 1);

                file.Close();
            }else {
                Console.WriteLine("Error: The file {0} could not be found", fileName);
            }
        }
    }
}
