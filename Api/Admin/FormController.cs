namespace Forms;

public class FormController : Controller<FormView, Form>
{
    public override ReadBusiness<FormView> ReadBusiness => new FormBusiness();

    public override Business<FormView, Form> Business => new FormBusiness();
}