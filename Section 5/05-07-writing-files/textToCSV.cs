using System;
using System.IO;
using System.Collections.Generic;

namespace textwriter
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0){
                
                string inputFile = args[0];
                string line = "";
                List<string> tmpBuffer = new List<string>();

                using (StreamReader sr = new StreamReader(inputFile))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        string [] newLine = line.Split(' ');
                        string tempLine = "";
                        foreach(string element in newLine){
                            tempLine += element + ",";
                        }
                        tmpBuffer.Add(tempLine.Remove(tempLine.Length -1 ));
                    }
                    string fileName = inputFile.Replace(".txt", ".csv");
                    File.WriteAllLines(fileName,tmpBuffer);
                }
            }else {
                Console.WriteLine("You must specify the input filename");
            }
        }
    }
}
