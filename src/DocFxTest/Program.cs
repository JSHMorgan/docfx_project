namespace DocFxTest;

/// <summary>
/// Docs
/// </summary>
internal class Program
{
    /// <summary>
    /// Docs
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.WriteLine(HelloWorld());
        int sum = MyMaths.Add(4, 4);
        Console.WriteLine(sum);
    }

    /// <summary>
    /// A function to give the user "Hello, World!" in a string format.
    /// </summary>
    /// <returns>A string of the text "Hello, World!"</returns>
    public static string HelloWorld()
    {
        return "Hello, World!";
    }
}
