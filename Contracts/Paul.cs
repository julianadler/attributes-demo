namespace Contracts;

public class PaulContract
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Contract: {Name}, {Age}";
    }
}
