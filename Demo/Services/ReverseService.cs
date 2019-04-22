using System;

namespace Demo.Services
{
    public class ReverseService
    {
        /// <summary>
        /// Reverse String With Reverse Function of Array
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static string ReverseStringWithReverseFunc(string inputStr)
        {
            var result = "";
            var arrayStr = inputStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arrayStr);
            result = String.Join(" ", arrayStr);
            return result != "" ? result : "Reverse string failed, please try again.";
        }

        /// <summary>
        ///Reverse String With "for" Cycle
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static string ReverseStringWithCycle(string inputStr)
        {
            var result = "";
            var arrayStr = inputStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = arrayStr.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    result += arrayStr[i];
                    break;
                }
                result += arrayStr[i] + " ";
            }
            return result != "" ? result : "Reverse string failed, please try again.";
        }
    }
}
