namespace Katas
{
    using System;

    public class DeleteADigit
    {
        private const int MIN = 10;
        private const int MAX = 1000000;

        public int DeleteDigit(int inputNumber)
        {
            HandleOutOfRangeException(inputNumber);

            int currentMax = int.MinValue;
            string numberAsString = inputNumber.ToString();
            for (int index = 0; index < numberAsString.Length; index++)
                currentMax = UpdateMaxValue(currentMax, numberAsString, index);

            return currentMax;
        }

        private void HandleOutOfRangeException(int inputNumber)
        {
            if (inputNumber < MIN || inputNumber > MAX)
                throw new ArgumentOutOfRangeException($"{nameof(inputNumber)} should be between {MIN} and {MAX}");
        }

        private int UpdateMaxValue(int currentMax, string number, int index)
        {
            int currentNumber = GetModifiedNumber(number, index);
            if (currentNumber > currentMax)
                currentMax = currentNumber;

            return currentMax;
        }

        private static int GetModifiedNumber(string number, int index)
            => int.Parse(number.Substring(0, index) + number.Substring(index + 1));
    }
}
