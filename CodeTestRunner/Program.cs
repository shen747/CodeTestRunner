using CodeTestRunner;


class Program
{
    static void Main(string[] args)
    {   
        var sfOutput = StringFormatter.ToCommaSeparatedList(["a", "b", "c"], "'");        
        Console.WriteLine($"sfOutput --> {sfOutput}");
        Console.ReadLine();
    }
}