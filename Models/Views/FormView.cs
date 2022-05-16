namespace Forms;

public class FormView : IEntity, IGuid, IKey
{
    public FormView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public Guid Guid { get; set; }

    public string Name { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Key { get; set; }

    public long? FieldsCount { get; set; }

    public dynamic RelatedItems { get; set; }
}
