namespace SOLID_CSharp;

public class OrderProcessor
{
    private FileLogger _logger;

    public OrderProcessor()
    {
        _logger = new FileLogger(); // Direct dependency on a concrete implementation
    }

    public void ProcessOrder(string order)
    {
        // Process order logic
        Console.WriteLine($"Processing order: {order}");
        
        // Log the order processing
        _logger.Log($"Order processed: {order}");
    }
}