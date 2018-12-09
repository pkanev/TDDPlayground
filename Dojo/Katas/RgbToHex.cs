namespace Katas
{
    public static class RgbToHex
    {
        private const int MIN = 0;
        private const int MAX = 255;
        private const string X2_FORMAT = "X2";

        public static string Rgb(int red, int green, int blue)
            => $"{NormalizeColorValue(red).ToString(X2_FORMAT)}{NormalizeColorValue(green).ToString(X2_FORMAT)}{NormalizeColorValue(blue).ToString("X2")}";

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
