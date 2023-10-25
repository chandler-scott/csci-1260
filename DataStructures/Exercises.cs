using System.Threading;

namespace DataStructures;

public static class Exercises
{
    private static string _question;
    private static int _countdownSeconds;

    static Exercises()
    {
        _question = string.Empty;
        _countdownSeconds = 0;
    }

    private static void runTimer() 
    {
        for (int i = _countdownSeconds; i > 0; i--)
        {

            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"Time left: {TimeSpan.FromSeconds(i)} seconds");
            Thread.Sleep(1000); // Wait for 1 second
        }

        Console.WriteLine("\n Time's up!");
    }

    public static void Array1()
    {
        _question = "What does the following code do?\n\tint[] monthlySales = new int[];\n";
        _countdownSeconds = 3 * 60; // 3 mins

        Console.WriteLine(_question);
        runTimer();
    }
}
