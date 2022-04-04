namespace Forms;

public class FieldTypeBusiness : EnumBusiness<FieldType>
{
    public override string ConnectionString => Forms.Repository.Form.ConnectionString;
}