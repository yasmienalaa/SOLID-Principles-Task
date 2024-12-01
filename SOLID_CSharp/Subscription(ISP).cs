namespace SOLID_CSharp;

// Violates ISP by having all possible subscription properties
public class Subscription
{
    public string Email { get; set; }
    public string Type { get; set; }
    public int MaxUsers { get; set; }
    public int MaxStorage { get; set; }
    public bool HasSupport { get; set; }
}
