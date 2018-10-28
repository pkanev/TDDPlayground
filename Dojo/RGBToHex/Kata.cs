namespace RGBToHex
{
    public static class Kata
    {
        private const int MIN = 0;
        private const int MAX = 255;

        public static string Rgb(int red, int green, int blue)
            => $"{NormalizeColorValue(red).ToString("X2")}{NormalizeColorValue(green).ToString("X2")}{NormalizeColorValue(blue).ToString("X2")}";

        private static int NormalizeColorValue(int color)
        {
            if (color > MAX)
                return MAX;
            if (color < MIN)
                return MIN;
            return color;
        }
    }
}
