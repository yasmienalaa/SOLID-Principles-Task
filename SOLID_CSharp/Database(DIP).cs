namespace SOLID_CSharp;

// Violates DIP by being a concrete implementation with no abstractions
class Database
{
    private readonly Dictionary<string, Subscription> _subscriptions = new();
    
    public void SaveSubscription(Subscription subscription)
    {
        // Direct database implementation
        _subscriptions[subscription.Email] = subscription;
        Console.WriteLine($"Saving subscription for {subscription.Email} to database");
    }
    public Subscription GetSubscription(string email)
    {
        // Direct database implementation
        Console.WriteLine($"Retrieving subscription for {email} from database");
        return _subscriptions.ContainsKey(email) 
            ? _subscriptions[email] 
            : new Subscription { Email = email, Type = "Basic" };
    }
}