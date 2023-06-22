namespace HelloWorld;

class Program
{
    static void Main()
    {
        var H = "Hello World!";
        var W = new Func<Func<Func<string>>>(() => (() => (() => H)));

        var HFunc = W()()();

        Console.WriteLine(HFunc);

        Console.ReadKey();
    }
}