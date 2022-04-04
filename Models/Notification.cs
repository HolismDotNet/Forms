namespace Forms;

public class Notification : IEntity
{
    public Notification()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string SendEmail { get; set; }

    public string EmailsCsv { get; set; }

    public string SendSms { get; set; }

    public string PhoneNumbersCsv { get; set; }

    public dynamic RelatedItems { get; set; }
}
