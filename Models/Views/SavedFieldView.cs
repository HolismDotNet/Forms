namespace Forms;

public class SavedFieldView : IEntity
{
    public SavedFieldView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long SavedFormId { get; set; }

    public long FieldId { get; set; }

    public string Value { get; set; }

    public string Title { get; set; }

    public dynamic RelatedItems { get; set; }
}
