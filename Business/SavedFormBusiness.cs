namespace Forms;

public class SavedFormBusiness : Business<SavedForm, SavedForm>
{
    protected override Read<SavedForm> Read => Forms.Repository.SavedForm;

    protected override Write<SavedForm> Write => Forms.Repository.SavedForm;
}