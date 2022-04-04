namespace Forms;

public class SavedForm : IEntity
{
    public SavedForm()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long FormId { get; set; }

    public DateTime UtcDate { get; set; }

    public dynamic RelatedItems { get; set; }
}
