using System;
using Demo.Services;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Reverse String according to word
            ////Approach 1: Reverse Function of Array
            var reverseStr1 = ReverseService.ReverseStringWithReverseFunc("hello world");
            Console.WriteLine(reverseStr1);
            ////Approach 2: "for" Cycle
            var reverseStr2 = ReverseService.ReverseStringWithCycle("hello world");
            Console.WriteLine(reverseStr2);


            //Task 2: Check Array Duplicate
            Console.WriteLine("Please entry an int array, connect each option with \",\":");
            var inputDuplicateStr = Console.ReadLine();
            ////Approach 1: Array Contains
            var duplicateStr1 = DuplicateCheckedService.ShowDuplicateOptionWithArrayContains(inputDuplicateStr);
            Console.WriteLine(duplicateStr1);
            ////Approach 2: Double "for" Cycle
            var duplicateStr2 = DuplicateCheckedService.ShowDuplicateOptionWithDoubleCycle(inputDuplicateStr);
            Console.WriteLine(duplicateStr2);
        }
    }
}
