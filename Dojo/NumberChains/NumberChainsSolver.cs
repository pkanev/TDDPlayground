using System;
using System.Collections.Generic;

namespace NumberChains
{
    public class NumberChainsSolver
    {
        public int Solver(int input)
        {
            int previous = int.MinValue;
            int number = input;
            int chainLength = 0;
            int[] minMax;

            while (number != previous)
            {
                chainLength++;
                minMax = GetMinAndMaxNumbers(number);
                previous = number;
                number = minMax[1] - minMax[0];
            }

            return chainLength;
        }

        private int[] GetMinAndMaxNumbers(int input)
        {
            List<int> digits = GetSortedDigitsInNumber(input);
            int min = 0;
            int max = 0;
            for (int index = 0, minPower = digits.Count - 1, maxPower = 0;
                    index < digits.Count;
                    index++, minPower --, maxPower++)
            {
                max += digits[index] * (int)Math.Pow(10, maxPower);
                min += digits[index] * (int)Math.Pow(10, minPower);
            }

            return new int[] { min, max };
        }

        private List<int> GetSortedDigitsInNumber(int number)
        {
            List<int> digits = new List<int>();
            while (number > 9)
            {
                int remainder = number % 10;
                digits.Add(remainder);
                number /= 10;
            }

            digits.Add(number);
            digits.Sort();
            return digits;
        }
    }
}
