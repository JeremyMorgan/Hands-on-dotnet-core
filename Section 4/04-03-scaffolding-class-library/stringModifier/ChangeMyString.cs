using System;

namespace stringModifier
{
    public class ChangeMyString
    {
        public static string makeAllUppercase(string inputString){
            return inputString.ToUpper();
        }

        public static string makeReverse(string inputString){
            char[] arr = inputString.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
