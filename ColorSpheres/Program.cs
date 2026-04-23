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

        public int getRed()
        {
            return red;
        }

        public int getGreen()
        {
            return green;
        }

        public int getBlue()
        {
            return blue;
        }

        public int getAlpha()
        {
            return alpha;
        }

        public int getGray()
        {
            return (red + green + blue) / 3;
        }
    }
}
