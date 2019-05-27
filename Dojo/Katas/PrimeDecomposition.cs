namespace Katas
{
    using System;
    using System.Collections.Generic;

    public class PrimeDecomposition
    {
        public static string Factors(int number)
        {
            List<int> primeNumbers = new List<int>() { 2 };
            int factor = 2;
            Dictionary<int, int> occurences = new Dictionary<int, int>();

            while (number != 1)
            {
                if (number % factor == 0)
                {
                    number /= factor;
                    if (!occurences.ContainsKey(factor))
                        occurences[factor] = 0;

                    occurences[factor]++;
                }
                else
                {
                    factor = GetNextPrimeNumber(factor, primeNumbers);
                    primeNumbers.Add(factor);
                }
            }

            return GenerateResult(occurences);
        }

        private static int GetNextPrimeNumber(int factor, List<int> primeNumbers)
        {
            int number = factor + 1;
            bool isPrime;

            do
            {
                isPrime = true;
                foreach (int primeNumber in primeNumbers)
                {
                    if (number % primeNumber == 0 && primeNumber <= Math.Sqrt(number))
                    {
                        isPrime = false;
                        number++;
                        break;
                    }
                }
            } while (!isPrime);

            return number;
        }

        private static string GenerateResult(Dictionary<int, int> occurences)
        {
            string result = string.Empty;
            foreach (var kvp in occurences)
                result += BuildFactorAsString(result, kvp.Key, kvp.Value);

            return result;
        }

        private static string BuildFactorAsString(string result, int prime, int power)
            => power == 1 ? $"({prime})" : $"({prime}**{power})";
    }
}
