namespace SOLID_CSharp;

// Violates DIP by being a concrete implementation with no abstractions
public interface DI
{
    void SaveSubscription(Subscription subscription);
    Subscription GetSubscription(string email);
}
public class Database : DI
{
    private readonly Dictionary<string, Subscription> _subscriptions = new();

    public void SaveSubscription(Subscription subscription)
    {
        _subscriptions[subscription.Email] = subscription;
        Console.WriteLine($"Saving subscription for {subscription.Email} to database");
    }

    public Subscription GetSubscription(string email)
    {
        Console.WriteLine($"Retrieving subscription for {email} from database");
        return _subscriptions.ContainsKey(email)
            ? _subscriptions[email]
            : new Subscription { Email = email, Type = "Basic" };
    }
}
