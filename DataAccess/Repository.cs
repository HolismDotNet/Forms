namespace Forms;

public class Repository
{
    public static Write<Forms.FieldChoice> FieldChoice
    {
        get
        {
            return new Write<Forms.FieldChoice>(new FormsContext());
        }
    }

    public static Write<Forms.Field> Field
    {
        get
        {
            return new Write<Forms.Field>(new FormsContext());
        }
    }

    public static Write<Forms.FieldView> FieldView
    {
        get
        {
            return new Write<Forms.FieldView>(new FormsContext());
        }
    }

    public static Write<Forms.Form> Form
    {
        get
        {
            return new Write<Forms.Form>(new FormsContext());
        }
    }

    public static Write<Forms.FormView> FormView
    {
        get
        {
            return new Write<Forms.FormView>(new FormsContext());
        }
    }

    public static Write<Forms.Notification> Notification
    {
        get
        {
            return new Write<Forms.Notification>(new FormsContext());
        }
    }

    public static Write<Forms.SavedField> SavedField
    {
        get
        {
            return new Write<Forms.SavedField>(new FormsContext());
        }
    }

    public static Write<Forms.SavedFormJson> SavedFormJson
    {
        get
        {
            return new Write<Forms.SavedFormJson>(new FormsContext());
        }
    }

    public static Write<Forms.SavedForm> SavedForm
    {
        get
        {
            return new Write<Forms.SavedForm>(new FormsContext());
        }
    }
}
