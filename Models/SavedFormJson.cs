namespace Forms;

public class SavedFormJson : IEntity
{
    public SavedFormJson()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Json { get; set; }

    public dynamic RelatedItems { get; set; }
}
