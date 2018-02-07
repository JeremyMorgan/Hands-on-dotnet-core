using System;

namespace hwfancy
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime anniversary = new DateTime(1970, 1, 1);
            string result = string.Format("The day of epoch was on a {0}", anniversary.ToString("dddd"));
            Console.WriteLine(result);
        }
    }
}
