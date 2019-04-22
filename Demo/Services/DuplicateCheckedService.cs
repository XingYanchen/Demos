using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class DuplicateCheckedService
    {
        /// <summary>
        /// Show Duplicate Option With Array sContains
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static string ShowDuplicateOptionWithArrayContains(string inputStr)
        {
            var result = "";
            var newArray = inputStr.Split(new char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries);
            var tempArray = new string[newArray.Length];
            var tempArrayToDoubleConfirm = new string[newArray.Length];
            var index = 0;
            foreach (var item in newArray)
            {
                if (tempArray.Contains(item))
                {
                    if (!tempArrayToDoubleConfirm.Contains(item))
                        result += item + ",";
                    tempArrayToDoubleConfirm[index] = item;
                }
                else
                    tempArray[index] = item;
                index++;
            }
            return result != "" ? result.Substring(0, result.Length - 1) : "There is no duplicate option, please check it.";
        }

        /// <summary>
        /// Show Duplicate Option With Double "for" Cycle
        /// </summary>
        /// <param name="inputStr"></param>
        /// <returns></returns>
        public static string ShowDuplicateOptionWithDoubleCycle(string inputStr)
        {
            var result = "";
            var newArray = inputStr.Split(new char[] { ',', '，' }, StringSplitOptions.RemoveEmptyEntries);
            var tempArrayToDoubleConfirm = new string[newArray.Length];
            for (var i = 0; i < newArray.Length - 1; i++)
            {
                for (var j = i + 1; j < newArray.Length; j++)
                {
                    if (newArray[i] == newArray[j])
                    {
                        if (!tempArrayToDoubleConfirm.Contains(newArray[i]))
                            result += newArray[i] + ",";
                        tempArrayToDoubleConfirm[i] = newArray[i];
                    }
                }
            }
            return result != "" ? result.Substring(0, result.Length - 1) : "There is no duplicate option, please check it.";
        }
    }
}
