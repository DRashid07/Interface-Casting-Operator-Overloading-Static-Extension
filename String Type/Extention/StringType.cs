namespace String_Type.Extention
{
    static class StringType
    {
        public static int MatchCount(this string str, string word)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrEmpty(word))
            {
                return 0;
            }

            int count = 0;
            int index = 0;
            while ((index = str.IndexOf(word, index, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
                index += word.Length;
            }
            return count;
        }
        public static bool Polindrom(this int num)
        {
            if (num < 0) return false;
            int originalNum = num;
            int reversedNum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = reversedNum * 10 + digit;
                num /= 10;
            }
            return originalNum == reversedNum;
        }
    }
}
