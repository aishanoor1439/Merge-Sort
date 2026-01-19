using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        // Main method

        static void Main(string[] args)
        {
            MergeSort ob = new MergeSort();
            int[] arr = { 12, 11, 13, 5, 6, 7 };

            Console.WriteLine("Given Array");
            ob.printArray(arr);

            
            ob.sort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nSorted array");
            ob.printArray(arr);
        }


    }
}
