namespace Forms;

public class FormBusiness : Business<Form, Form>
{
    protected override Read<Form> Read => Forms.Repository.Form;

    protected override Write<Form> Write => Forms.Repository.Form;
}