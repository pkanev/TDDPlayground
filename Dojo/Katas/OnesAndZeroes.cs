namespace Katas
{
    using System;

    public class OnesAndZeroes
    {
        public static int BinaryArrayToNumber(int[] binaryArray)
        {
            int result = 0;
            for (int index = binaryArray.Length - 1, power = 0; index >= 0; index--, power++)
                result += binaryArray[index] * (int)Math.Pow(2, power);

            return result;
        }
    }
}
