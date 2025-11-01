using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp9.Extention
{
    internal static class IntMethods
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
        public static bool IsContainsDigit(this string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }
        public static void ToCapitalize(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return;
            str = char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
        public static int[] GetValueIndexes(this string text, char value)
        {
            if (string.IsNullOrEmpty(text))
                return Array.Empty<int>();

            List<int> indexes = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == value)
                    indexes.Add(i);
            }

            return indexes.ToArray();
        }
        public static string GetFirstSentence(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            int dotIndex = text.IndexOf('.');
            if (dotIndex == -1) return text;

            return text.Substring(0, dotIndex + 1).Trim();
        }
        public static string GetSecondWord(this string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return "";

            var words = text.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return words.Length >= 2 ? words[1] : "";
        }
    }
}
