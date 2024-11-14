namespace OOP_Labb_4.utls;

public static class HelpConsole
{
    /// <summary>
    /// Skriver ut en devider med ett nummer i mitten.
    /// </summary>
    /// <param name="number"></param>
    public static void Devider(int number)
    {
        Console.WriteLine($"\u001b[32m########\u001b[35m{number:00}\u001b[32m########\u001b[0m\n");
    }
    /// <summary>
    /// Skriver ut en devider med ett nummer i mitten. Möjlighet att ändra färg på devider och nummer.
    /// </summary>
    /// <param name="number"></param>
    /// <param name="deviderColor">Färg på devider</param>
    /// <param name="colorNumber">Färg på devider nummer</param>
    public static void Devider(int number, ConsoleColor deviderColor, ConsoleColor colorNumber = ConsoleColor.White)
    {
        Console.ForegroundColor = deviderColor;
        Console.Write("########");
        Console.ForegroundColor = colorNumber;
        Console.Write($"{number:00}");
        Console.ForegroundColor = deviderColor;
        Console.WriteLine("########");
        Console.ResetColor();
    }

    /// <summary>
    /// Skriver ut en devider.
    /// </summary>
    public static void InnerDevider()
    {
        Console.WriteLine("\u001b[32m~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\u001b[0m\n");
    }
    
    /// <summary>
    /// Skriver ut en devider. Möjlighet att ändra färg på devider.
    /// </summary>
    /// <param name="deviderColor"></param>
    public static void InnerDevider(ConsoleColor deviderColor)
    {
        Console.ForegroundColor = deviderColor;
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.ResetColor();
    }
}
