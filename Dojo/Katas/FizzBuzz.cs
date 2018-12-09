namespace Katas
{
    using System.Collections.Generic;

    public class FizzBuzz
    {
        private const string FIZZ = "Fizz";
        private const string BUZZ = "Buzz";

        public string PrintResult(int maxValue)
        {
            List<string> results = new List<string>();
            for (int i = 1; i <= maxValue; i++)
                results.Add(CalculateValue(i));

            return string.Join(',', results);
        }

        private static string CalculateValue(int i)
        {
            string value = string.Empty;
            if (i % 3 == 0)
                value += FIZZ;

            if (i % 5 == 0)
                value += BUZZ;

            if (string.IsNullOrEmpty(value))
                value = i.ToString();
            return value;
        }
    }
}
