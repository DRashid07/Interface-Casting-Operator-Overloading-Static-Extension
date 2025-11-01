namespace StudentClass.Models
{
    public class Student
    {
        public string FullName { get; private set; }
        public string GroupNo { get; private set; }
        public int Age { get; private set; }
        public Student(string fullName, string groupNo, int age)
        {
            if (!CheckFullname(fullName))
            {
                throw new Exception("FullName sehvdir");
            }
            if (!CheckGroupNo(groupNo))
            {
                throw new Exception("GroupNo sehvdir");
            }
            if (age<=0)
            {
                throw new Exception("Age sehvdir");
            }

            FullName = fullName;
            GroupNo = groupNo;
            Age = age;
        }
        private static bool CheckFullname(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return false;
            }
            string[] strings = fullName.Split(' ');
            if (strings.Length < 2)
            {
                return false;
            }
            return char.IsUpper(strings[0][0]) && char.IsUpper(strings[1][0]);
        }
        private static bool CheckGroupNo(string groupNo)
        {
            if (string.IsNullOrWhiteSpace(groupNo) || groupNo.Length != 4)
            {
                return false;
            }
            if (!char.IsUpper(groupNo[0]) || !char.IsDigit(groupNo[1]) || !char.IsDigit(groupNo[2]) || !char.IsDigit(groupNo[3]))
            {
                return true;
            }
            return true;

        }

    }
}
