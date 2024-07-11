namespace Contracts;

public class PaulContract
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Contract: {Name}";
    }
}
