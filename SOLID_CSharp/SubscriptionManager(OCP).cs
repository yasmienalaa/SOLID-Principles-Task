namespace SOLID_CSharp;
// Violates OCP by handling subscription features directly in methods
public class SubscriptionManager
{
    private readonly Database _database = new();

    // Violates OCP: Direct implementation of subscription types
    public void CreateSubscription(string email, string subscriptionType)
    {
        var subscription = new Subscription { Email = email, Type = subscriptionType };
        
        switch (subscriptionType)
        {
            case "Basic":
                SetBasicFeatures(subscription);
                break;
            case "Pro":
                SetProFeatures(subscription);
                break;
            case "Enterprise":
                SetEnterpriseFeatures(subscription);
                break;
            default:
                throw new ArgumentException("Invalid subscription type");
        }

        _database.SaveSubscription(subscription);
    }

    // Violates OCP: Direct implementation of feature processing
    public void ProcessFeatures(string email)
    {
        var subscription = _database.GetSubscription(email);
        
        switch (subscription.Type)
        {
            case "Basic":
                ProcessBasicFeatures(subscription);
                break;
            case "Pro":
                ProcessProFeatures(subscription);
                break;
            case "Enterprise":
                ProcessEnterpriseFeatures(subscription);
                break;
            default:
                throw new ArgumentException("Invalid subscription type");
        }
    }

    // Direct implementation of features violates OCP
    private void SetBasicFeatures(Subscription subscription)
    {
        subscription.MaxUsers = 5;
        subscription.MaxStorage = 10;
        subscription.HasSupport = false;
    }

    private void SetProFeatures(Subscription subscription)
    {
        subscription.MaxUsers = 50;
        subscription.MaxStorage = 100;
        subscription.HasSupport = true;
    }

    private void SetEnterpriseFeatures(Subscription subscription)
    {
        subscription.MaxUsers = 500;
        subscription.MaxStorage = 1000;
        subscription.HasSupport = true;
    }

    private void ProcessBasicFeatures(Subscription subscription)
    {
        Console.WriteLine($"Processing basic features for {subscription.Email}");
        Console.WriteLine("- Limited file storage");
        Console.WriteLine("- Basic reporting");
    }

    private void ProcessProFeatures(Subscription subscription)
    {
        Console.WriteLine($"Processing pro features for {subscription.Email}");
        Console.WriteLine("- Advanced file storage");
        Console.WriteLine("- Advanced reporting");
        Console.WriteLine("- Priority support");
    }

    private void ProcessEnterpriseFeatures(Subscription subscription)
    {
        Console.WriteLine($"Processing enterprise features for {subscription.Email}");
        Console.WriteLine("- Unlimited file storage");
        Console.WriteLine("- Custom reporting");
        Console.WriteLine("- 24/7 dedicated support");
        Console.WriteLine("- Custom integrations");
    }
}