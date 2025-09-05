namespace DotNet10Configuration;

public class Element
{
    public int? NullableInt32 { get; set; }
    public int? NullableInt32WithDefaultZero { get; set; } = 0;
    public int? NullableInt32WithDefaultValue { get; set; } = 1;
    public int NonNullableInt32 { get; set; }
    public int NonNullableInt32WithDefaultZero { get; set; }
    public int NonNullableInt32WithDefaultValue { get; set; } = 1;

    public string? NullableString { get; set; }
    public string? NullableStringWithDefaultEmpty { get; set; } = string.Empty;
    public string? NullableStringWithDefaultValue { get; set; } = "Value";
    public string NonNullableString { get; set; } = null!;
    public string NonNullableStringWithDefaultEmpty { get; set; } = string.Empty;
    public string NonNullableStringWithDefaultValue { get; set; } = "Value";
}

public sealed class Container : Element
{
    public Element? NullableChild { get; set; }
    public Element? NullableChildWithDefaultEmpty { get; set; } = new();
    public Element NonNullableChild { get; set; } = null!;
    public Element NonNullableChildWithDefaultEmpty { get; set; } = new();

    public IList<Element>? NullableChildren { get; set; }
    public IList<Element>? NullableChildrenWithDefaultEmpty { get; set; } = [];
    public IList<Element> NonNullableChildren { get; set; } = null!;
    public IList<Element> NonNullableChildrenWithDefaultEmpty { get; set; } = [];

    public IDictionary<string, Element>? NullableNamedChildren { get; set; }
    public IDictionary<string, Element>? NullableNamedChildrenWithDefaultEmpty { get; set; } = new Dictionary<string, Element>();
    public IDictionary<string, Element> NonNullableNamedChildren { get; set; } = null!;
    public IDictionary<string, Element> NonNullableNamedChildrenWithDefaultEmpty { get; set; } = new Dictionary<string, Element>();
}
