namespace Forms;

public class FieldBusiness : Business<Field, Field>
{
    protected override Read<Field> Read => Forms.Repository.Field;

    protected override Write<Field> Write => Forms.Repository.Field;
}