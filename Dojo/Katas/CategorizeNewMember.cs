namespace Katas
{
    using System.Collections.Generic;

    public class CategorizeNewMember
    {
        const int SENIOR_AGE = 55;
        const int HANDICAP_THRESHHOLD = 7;
        const string OPEN = "Open";
        const string SENIOR = "Senior";

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            List<string> result = new List<string>();
            for (int index = 0, length = data.Length; index < length; index++)
                result.Add(IsSenior(data[index]) ? SENIOR : OPEN);

            return result;
        }

        private static bool IsSenior(int[] AgeAndHandicapPair)
            => AgeAndHandicapPair[0] >= SENIOR_AGE && AgeAndHandicapPair[1] > HANDICAP_THRESHHOLD;
    }
}
