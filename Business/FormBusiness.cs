namespace Forms;

public class FormBusiness : Business<FormView, Form>
{
    protected override Read<FormView> Read => Forms.Repository.FormView;

    protected override Write<Form> Write => Forms.Repository.Form;

    public object GetWithFields(string key)
    {
        var form = new FormBusiness().GetByKey(key);
        var fields = new FieldBusiness().GetFields(form.Id);
        dynamic fieldsJson = new ExpandoObject();
        foreach (var field in fields)
        {
            ExpandoObjectExtensions.AddProperty(fieldsJson, field.Key, field);
        }
        return new 
        {
            form,
            Fields = fieldsJson
        };
    }
}