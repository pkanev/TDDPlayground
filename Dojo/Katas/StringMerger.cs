namespace Katas
{
    public class StringMerger
    {
        public static bool isMerge(string word, string partA, string partB)
        {
            if (string.IsNullOrEmpty(word))
                return string.IsNullOrEmpty(partA) && string.IsNullOrEmpty(partB);

            char letter = word[0];
            bool foundMerge = false;

            int indexA = partA.IndexOf(letter);
            if (indexA != -1)
                foundMerge = isMerge(word.Substring(1), partA.Substring(indexA + 1), partB);

            int indexB = partB.IndexOf(letter);
            if (indexB != -1)
                foundMerge = foundMerge || isMerge(word.Substring(1), partA, partB.Substring(indexB + 1));

            return foundMerge;
        }
    }
}
