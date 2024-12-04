namespace SOLID_CSharp;

// Violates ISP by having all possible subscription properties
public class Subscription
{
    public string Email { get; set; }
    public string Type { get; set; }

}


public interface MaxU
{
     int MaxUsers { get; set; }
}

public interface MaxS
{
     int MaxStorage { get; set; }

}

public interface Support
{
     bool HasSupport { get; set; }
}


