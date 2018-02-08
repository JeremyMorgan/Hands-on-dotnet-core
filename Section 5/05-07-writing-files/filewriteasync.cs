using System;
using System.IO;

namespace textwriter
{
    class Program
    {
        static void Main(string[] args)
        {
           string ourFile = "test.txt";
           string[] lines = { "Alpha", "Bravo", "Charlie" };

           WriteLines(ourFile, lines);
        }

        static async void WriteLines(string ourFile, string[] lines)
        {
            using (StreamWriter sw = new StreamWriter(ourFile, true))
            {
                foreach (string line in lines)
                {
                    await sw.WriteLineAsync(line);                    
                }
            }
        }
    }
}
