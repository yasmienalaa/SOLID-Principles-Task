namespace SOLID_CSharp;

public class FileLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Logging to file: {message}");
    }
}