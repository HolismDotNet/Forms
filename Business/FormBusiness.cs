namespace Forms;

public class FormBusiness : Business<FormView, Form>
{
    protected override Read<FormView> Read => Forms.Repository.FormView;

    protected override Write<Form> Write => Forms.Repository.Form;
}