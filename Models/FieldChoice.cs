namespace Forms;

public class FieldChoice : IEntity
{
    public FieldChoice()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long FieldId { get; set; }

    public string Choice { get; set; }

    public dynamic RelatedItems { get; set; }
}
