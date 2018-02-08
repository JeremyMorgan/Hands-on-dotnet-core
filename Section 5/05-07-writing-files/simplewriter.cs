using System;
using System.IO;

namespace textwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string ourFile = "test.txt";
            string textToWrite = "NEW STUddFF\n";
            
            if (File.Exists(ourFile))
            {
                string readText = File.ReadAllText(ourFile);
                File.WriteAllText(ourFile, textToWrite + readText);
            }
        }
    }
}
