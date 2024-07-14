namespace Gushwell.Utilities;

[AttributeUsage(AttributeTargets.Field)]
public sealed class EnumDisplayAttribute : Attribute {
    public string Name { get; init; }

    public EnumDisplayAttribute(string name) {
        Name = name;
    }
}

