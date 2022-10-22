public class Printer
{
    public void Print(string value)
    {
        Console.WriteLine(value);
        if (this is Printer)
        {
            Console.BackgroundColor=ConsoleColor.Red;
        }
    }
}
