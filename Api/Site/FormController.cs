namespace Forms;

public class FormController : HolismController
{
    [HttpPost]
    public IActionResult Save(string formKey)
    {
        return Ok(Request.Form.Select(i => i.Key).ToList());
    }
}