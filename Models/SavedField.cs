namespace Forms;

public class SavedField : IEntity
{
    public SavedField()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long SavedFormId { get; set; }

    public long FieldId { get; set; }

    public string Value { get; set; }

    public dynamic RelatedItems { get; set; }
}
