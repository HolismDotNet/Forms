namespace Forms;

public class FormsContext : DatabaseContext
{
    public override string ConnectionStringName => "Forms";

    public DbSet<Forms.FieldChoice> FieldChoices { get; set; }

    public DbSet<Forms.Field> Fields { get; set; }

    public DbSet<Forms.FieldView> FieldViews { get; set; }

    public DbSet<Forms.Form> Forms { get; set; }

    public DbSet<Forms.FormView> FormViews { get; set; }

    public DbSet<Forms.Notification> Notifications { get; set; }

    public DbSet<Forms.SavedField> SavedFields { get; set; }

    public DbSet<Forms.SavedFormJson> SavedFormJsons { get; set; }

    public DbSet<Forms.SavedForm> SavedForms { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
