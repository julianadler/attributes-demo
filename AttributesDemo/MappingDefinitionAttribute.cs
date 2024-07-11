namespace AttributesDemo;

[AttributeUsage(AttributeTargets.Assembly)]
public class MappingDefinitionAttribute : Attribute
{
    public Type From { get; }
    public Type To { get; }
    public bool Reverse { get; }

    public MappingDefinitionAttribute(
        Type from,
        Type to,
        bool reverse = true)
    {
        From = from;
        To = to;
        Reverse = reverse;
    }

    public override string ToString()
    {
        return $"From {From.FullName} to {To.FullName}, Reverse? {Reverse}";
    }
}
