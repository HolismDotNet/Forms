namespace Forms;

public class FieldController : Controller<Field, Field>
{
    public override ReadBusiness<Field> ReadBusiness => new FieldBusiness();

    public override Business<Field, Field> Business => new FieldBusiness();
}