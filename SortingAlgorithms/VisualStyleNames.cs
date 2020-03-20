using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    class VisualStyleNames
    {
        public static Dictionary<int, string> VisualStyle { get; } = new Dictionary<int, string>();

        public static void Init()
        {
            VisualStyle.Add(1, "Lines");
            VisualStyle.Add(2, "Dots");
        }
    }
}
