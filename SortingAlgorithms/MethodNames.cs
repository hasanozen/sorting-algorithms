using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    class MethodNames
    {
        public static Dictionary<int, string> Methods { get; } = new Dictionary<int, string>();

        public static void Init()
        {
            Methods.Add(1, "Selection Sort");
            Methods.Add(2, "Bubble Sort");
            Methods.Add(3, "Coctail Sort");
            Methods.Add(4, "Odd-Even Sort");
            Methods.Add(5, "Comb Sort");
            Methods.Add(6, "Insertion Sort");
            Methods.Add(7, "Shell Sort");
            Methods.Add(8, "Merge Sort");
            Methods.Add(9, "Counting Sort");
            Methods.Add(10, "Quick Sort"); //New
        }
        
    }
}
