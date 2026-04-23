using System;
using System.Runtime.CompilerServices;

namespace ColorSpheres
{
    public class Color
    {
        public int red;
        public int green;
        public int blue;
        public int alpha;

        public RGB(int r, int g, int b)
        {
            red = r;
            green = g;
            blue = b;
            alpha = 255;
        }
    }
}
