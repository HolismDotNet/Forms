namespace Forms;

public class Form : IEntity, IGuid, IKey
{
    public Form()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Key { get; set; }

    public dynamic RelatedItems { get; set; }
}
