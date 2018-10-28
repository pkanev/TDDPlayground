using System;

namespace CamelCase
{
    public static class Kata
    {
        public static string CamelCase(this string input)
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
