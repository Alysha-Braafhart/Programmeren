namespace funcall;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.Clear();
        string Write = "....X....";
        Console.Write(Write);
        Console.SetCursorPosition(4, 0);
        Console.ForegroundColor = ConsoleColor.Red;
        Write = "?";
        Console.Write(Write);
        Console.WriteLine();
        Console.ResetColor();
        Console.WriteLine("X was nothing.");
    }
}
