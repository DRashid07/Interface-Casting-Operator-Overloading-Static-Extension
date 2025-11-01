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
        public static bool IsContainsDigit(this string str)
        {
            return str.Any(char.IsDigit);
        }
        public static void ToCapitalize(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return;
            str = char.ToUpper(str[0]) + str.Substring(1).ToLower();
        }
        public static void GetValueIndexes()
        {
            char a = Console.ReadLine();
        }
    }
}
