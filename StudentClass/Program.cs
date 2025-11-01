using StudentClass.Models;

namespace StudentClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student st1 = new Student("Abbas Quliyev", "P16", 20);
                Console.WriteLine($"Student: {st1.FullName}, {st1.GroupNo}, {st1.Age}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xəta: " + ex.Message);
            }
        }
    }
}
