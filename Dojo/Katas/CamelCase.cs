namespace Katas
{
    using System;

    public static class CamelCase
    {
        public static string ToCamelCase(this string input)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                return result;
            }

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int index = 0; index < words.Length; index++)
                result += CapitalizeFirstLetter(words[index]);

            return result;
        }

        private static string CapitalizeFirstLetter(string word)
            => word[0].ToString().ToUpperInvariant() + word.Substring(1).ToLowerInvariant();
    }
}
