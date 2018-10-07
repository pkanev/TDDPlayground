using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzProcessor
    {
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
                value += "Fizz";

            if (i % 5 == 0)
                value += "Buzz";

            if (string.IsNullOrEmpty(value))
                value = i.ToString();
            return value;
        }
    }
}
