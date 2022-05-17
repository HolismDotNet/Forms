namespace Forms;

public class SavedFormView : IEntity, IKey
{
    public SavedFormView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long FormId { get; set; }

    public DateTime UtcDate { get; set; }

    public bool? Seen { get; set; }

    public string Key { get; set; }

    public string Title { get; set; }

    public long? FieldsCount { get; set; }

    public long? SavedFieldsCount { get; set; }

    public dynamic RelatedItems { get; set; }
}
