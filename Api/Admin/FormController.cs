namespace Forms;

public class FormController : Controller<Form, Form>
{
    public override ReadBusiness<Form> ReadBusiness => new FormBusiness();

    public override Business<Form, Form> Business => new FormBusiness();
}