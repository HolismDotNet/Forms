namespace Forms;

public class SavedFieldBusiness : Business<SavedField, SavedField>
{
    protected override Read<SavedField> Read => Forms.Repository.SavedField;

    protected override Write<SavedField> Write => Forms.Repository.SavedField;
}