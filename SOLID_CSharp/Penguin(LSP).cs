namespace SOLID_CSharp;

public class Penguin : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Penguin can't fly...");
    }
}