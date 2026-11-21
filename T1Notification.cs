using System;
namespace Models;

class Notification
{
    public string Recipient{get; set;}
    public string Message {get; set;}
    public virtual string Channel => "Overall ";

    public Notification(string recipient, string message)
    {
            Recipient = recipient;
            Message = message;
    }
    public  virtual void Send()
    {
            Console.WriteLine("Notification is sent.");
    }
    internal class SmsNotification : Notification
{
    public override string Channel => "SMS";

    public SmsNotification(string recipient, string message)
        : base(recipient, message) { }

    public override void Send()
    {
        Console.WriteLine(Channel);
        Console.WriteLine($"Oluvchi: {Recipient}");
        Console.WriteLine($"Xabar: {Message}");
}
}
internal class EmailNotification : Notification
{
    public override string Channel => "Email";

    public EmailNotification(string recipient, string message)
        : base(recipient, message) { }

    public override void Send()
    {
        Console.WriteLine(Channel);
        Console.WriteLine($"Oluvchi: {Recipient}");
        Console.WriteLine($"Xabar: {Message}");
    }
}


}

class EmailNotificaton(string recipient, string message) : Notification(recipient, message)
{
    public override string Channel => "SMS";

    public override void Send()
    {
        Console.WriteLine($"[{Channel}] Recipient: {Recipient}, Message: {Message}");
    }
}