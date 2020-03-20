using System.Collections.Generic;
using System.Drawing;

namespace SortingAlgorithms
{
    class Colorization
    {
        public static Dictionary<int, Color> ColorSchema = new Dictionary<int, Color>();

        public static void Init()
        {
            Color Turquoise = Color.FromArgb(26, 188, 156);
            Color Emerald = Color.FromArgb(46, 204, 113);
            Color Peter_River = Color.FromArgb(52, 152, 219);
            Color Alizarin = Color.FromArgb(231, 76, 60);
            Color Carrot = Color.FromArgb(230, 126, 34);
            Color Sun_Flower = Color.FromArgb(241, 196, 15);
            Color Amethyst = Color.FromArgb(155, 89, 182);

            ColorSchema.Add(0, Peter_River);
            ColorSchema.Add(1, Turquoise);
            ColorSchema.Add(2, Emerald);
            ColorSchema.Add(3, Alizarin);
            ColorSchema.Add(4, Carrot);
            ColorSchema.Add(5, Sun_Flower);
            ColorSchema.Add(6, Amethyst);
        }


    }
}
