namespace AlternatingSplit
{
    public static class Kata
    {
        public static string Encrypt(string text, int iterations)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            string result = text;
            for (int iteration = 0; iteration < iterations; iteration ++)
                result = EncryptOnce(result);

            return result;
        }

        public static string Decrypt(string encryptedText, int iterations)
        {
            if (string.IsNullOrEmpty(encryptedText))
                return encryptedText;

            string result = encryptedText;
            int splitIndex = result.Length / 2;
            for (int iteration = 0; iteration < iterations; iteration ++)
               result = DecryptOnce(result, splitIndex);

            return result;
        }        

        private static string EncryptOnce(string text)
        {
            string odds = string.Empty;
            string evens = string.Empty;
            for (int index = 0; index < text.Length; index++)
                if (index % 2 == 1)
                    odds += text[index];
                else
                    evens += text[index];

            return odds + evens;
        }

        private static string DecryptOnce(string encryptedText, int splitIndex)
        {
            string firstHalf = encryptedText.Substring(0, splitIndex);
            string secondHalf = encryptedText.Substring(splitIndex);
            string result = string.Empty;
            for (int index = 0; index < secondHalf.Length; index++)
            {
                result += secondHalf[index];
                if (index < firstHalf.Length)
                    result += firstHalf[index];
            }

            return result;
        }
    }
}
