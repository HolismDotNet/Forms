namespace Forms;

public class FieldBusiness : Business<FieldView, Field>
{
    protected override Read<FieldView> Read => Forms.Repository.FieldView;

    protected override Write<Field> Write => Forms.Repository.Field;

    public FieldView ToggleIsRequired(long id)
    {
        var field = Write.Get(id);
        field.IsRequired = field.IsRequired == null ? true : !field.IsRequired;
        Update(field);
        return Get(field.Id);
    }

    public FieldView ToggleDirection(long id)
    {
        var field = Write.Get(id);
        if (field.Direction == null)
        {
            field.Direction = "rtl";
        }
        else
        {
            field.Direction = field.Direction.ToLower() == "rtl" ? "ltr" : "rtl";
        }
        Update(field);
        return Get(field.Id);
    }
}