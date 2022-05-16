namespace Forms;

public class FormController : HolismController
{
    [HttpGet]
    public object Get(string key)
    {
        var form = new FormBusiness().GetWithFields(key);
        return form;
    }

    [HttpPost]
    public IActionResult Save(string formKey)
    {
        return Ok(Request.Form.Select(i => i.Key).ToList());
    }
}