namespace SOLID_CSharp;

public interface IPrinter
{
    void Print(string content);
    void Scan(string content);
    void Fax(string content);
}