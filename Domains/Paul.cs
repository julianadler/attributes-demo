namespace Domains;

public class PaulDomains
{
    public string Name { get; set; }
    public string City { get; set; }

    public override string ToString()
    {
        return $"Domain: {Name}, {City ?? "None"}";
    }
}
