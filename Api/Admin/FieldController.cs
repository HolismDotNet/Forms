namespace Forms;

public class FieldController : Controller<FieldView, Field>
{
    public override ReadBusiness<FieldView> ReadBusiness => new FieldBusiness();

    public override Business<FieldView, Field> Business => new FieldBusiness();

    [HttpPost]
    public FieldView ToggleIsRequired(long id)
    {
        var field = new FieldBusiness().ToggleIsRequired(id);
        return field;
    }

    [HttpPost]
    public FieldView ToggleDirection(long id)
    {
        var field = new FieldBusiness().ToggleDirection(id);
        return field;
    }
}