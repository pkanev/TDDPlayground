namespace Katas
{
    using System.Collections.Generic;

    public class TwoToOne
    {
        public static string Longest(params string[] inputStrings)
        {
            SortedSet<char> letters = new SortedSet<char>();
            foreach (string inputString in inputStrings)
                foreach (char letter in inputString)
                    letters.Add(letter);

            return string.Concat(letters);
        }
    }
}
