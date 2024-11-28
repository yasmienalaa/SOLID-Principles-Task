namespace SOLID_CSharp;

public class BasicPrinter : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine($"Printing: {content}");
    }

    public void Scan(string content)
    {
        throw new NotImplementedException();
    }

    public void Fax(string content)
    {
        throw new NotImplementedException();
    }
}