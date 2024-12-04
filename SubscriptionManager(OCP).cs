namespace SOLID_CSharp;
// Violates OCP by handling subscription features directly in methods
public class SubscriptionManager
{
    // Violates OCP: Direct implementation of subscription types
    public class SubscriptionCreator
    {
        private readonly DI _database;

        public SubscriptionCreator(DI database)
        {
            _database = database;
        }

        public Subscription CreateSubscription(string email, string subscriptionType)
        {
            var subscription = new Subscription { Email = email, Type = subscriptionType };
            _database.SaveSubscription(subscription);
            return subscription;
        }
    }

}

public interface SI
{
     void SetFeatures();
     void ProcessFeatures(Subscription subscription);
}

public class Basic :  MaxU, MaxS, Support, SI
{
    public int MaxUsers { get; set; }
    public int MaxStorage { get; set; }
    public bool HasSupport { get; set; }
    public void SetFeatures()
    {
        MaxUsers = 5;
        MaxStorage = 10;
        HasSupport = false;
    }
    public void ProcessFeatures(Subscription subscription)
    {
        Console.WriteLine($"Processing basic features for {subscription.Email}");
        Console.WriteLine("- Limited file storage");
        Console.WriteLine("- Basic reporting");
    }
}

public class Pro : MaxU, MaxS, Support, SI
{
    public int MaxUsers { get; set; }
    public int MaxStorage { get; set; }
    public bool HasSupport { get; set; }

    public void SetFeatures()
    {
        MaxUsers = 50;
        MaxStorage = 100;
        HasSupport = true;
    }
    public void ProcessFeatures(Subscription subscription)
    {
        Console.WriteLine($"Processing pro features for {subscription.Email}");
        Console.WriteLine("- Advanced file storage");
        Console.WriteLine("- Advanced reporting");
        Console.WriteLine("- Priority support");
    }
}
public class Enterprise : MaxU, MaxS, Support, SI
{
    public int MaxUsers { get; set; }
    public int MaxStorage { get; set; }
    public bool HasSupport { get; set; }
    public void SetFeatures()
    {
        MaxUsers = 500;
        MaxStorage = 1000;
        HasSupport = true;
    }
    public void ProcessFeatures(Subscription subscription)
    {
        Console.WriteLine($"Processing enterprise features for {subscription.Email}");
        Console.WriteLine("- Unlimited file storage");
        Console.WriteLine("- Custom reporting");
        Console.WriteLine("- 24/7 dedicated support");
        Console.WriteLine("- Custom integrations");
    }
}