namespace DsaPlayground;

static class Program
{
    static void Main()
    {
        Console.WriteLine(StringAlgorithms.IsUnique("helo"));
        Console.WriteLine(StringAlgorithms.UrlifyString(new char[8] {'h', 'e', ' ', 'l', 'l', 'o', ' ', ' '}, 6));
    }
}




