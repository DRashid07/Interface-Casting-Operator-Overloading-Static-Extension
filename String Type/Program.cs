using String_Type.Extention;

class Program
{
    static void Main()
    {
        string text = "Salam Kamran. Necesen Kamran?";
        Console.WriteLine(text.MatchCount("Kamran"));

        int num = 12321;
        Console.WriteLine(num.Polindrom());
    }
}
