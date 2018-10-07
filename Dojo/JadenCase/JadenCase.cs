using System.Collections.Generic;

namespace JadenCase
{
    public static class JadenCase
    {
        private static HashSet<char> wordSeparators = new HashSet<char>
        {
            ' ', '.', '.', '!', '?', ',', '"', ':', ';'
        };

        public static string ToJadenCase(this string phrase)
        {
            string result = string.Empty;
            for (int index = 0, phraseLength = phrase.Length; index < phraseLength; index ++)
            {
                if (ShouldBeUpperCase(phrase, index))
                    result += phrase[index].ToString().ToUpper();
                else
                    result += phrase[index].ToString().ToLower();
            }

            return result;
        }

        private static bool ShouldBeUpperCase(string phrase, int index)
            => index == 0 || wordSeparators.Contains(phrase[index - 1]);
    }
}
