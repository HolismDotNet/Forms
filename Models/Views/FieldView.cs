namespace Forms;

public class FieldView : IEntity, IKey, IOrder
{
    public FieldView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long FormId { get; set; }

    public string Key { get; set; }

    public long FieldTypeId { get; set; }

    public string Label { get; set; }

    public string Placeholder { get; set; }

    public string Hint { get; set; }

    public string Icon { get; set; }

    public bool? IsRequired { get; set; }

    public string Regex { get; set; }

    public string DefaultValue { get; set; }

    public string Direction { get; set; }

    public long Order { get; set; }

    public string Type { get; set; }

    public dynamic RelatedItems { get; set; }
}
