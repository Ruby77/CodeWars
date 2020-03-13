using System;

namespace RGB_To_Hex_Conversion
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string Rgb(int r, int g, int b)
        {
            r = Math.Min(Math.Max(r, 0), 255);
            g = Math.Min(Math.Max(g, 0), 255);
            b = Math.Min(Math.Max(b, 0), 255);
            return $"{r:X2}{g:X2}{b:X2}";
        }
    }
}
