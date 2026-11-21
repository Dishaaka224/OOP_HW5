using System;
namespace Models;

class Programm 
{
    private static IEnumerable<object> notifications;

    static void Main()
    {
        Console.WriteLine("\n1. Notification: ");
        Notification[] notification =

        {
            
            new EmailNotification("ali@mail.com", "Salom, Ali!"),
            new SmsNotification("+998901234567", "Kodingiz: 1234")
        };

        foreach (var n in notification)
            n.Send();
        Console.WriteLine("\n2. Payments: ");
        Payment[] payments =
        {
            new CardPayment(),
            new BankTransferPayment(),
            new WalletPayment()
        };

        foreach (var payment in payments)
            payment.Pay(50000); 
    
        Console.WriteLine("\n3. ReportPrinter: ");
        var printer = new ReportPrinter();
        printer.Print("Oylik hisobot");
        printer.Print("Oylik hisobot", 125000);

        Console.WriteLine("\n4. ReportExporter: ");
        string report = "Oylik savdo: 125000 so‘m";

        ReportExporter[] exporters =
        {
            new PdfReportExporter(),
            new CsvReportExporter()
        };

        foreach (var exporter in exporters)
        exporter.Export(report);
        
        }
    }



internal class ReportExporter
{
    public virtual void Export(string data)
    {
        Console.WriteLine($"Hisobot umumiy formatda eksport qilindi: {data}");
    }
}

internal class SmsNotification : Notification
{
    public SmsNotification(string recipient, string message) : base(recipient, message)
    {
    }
}

internal class EmailNotification : Notification
{
    public EmailNotification(string recipient, string message) : base(recipient, message)
    {
    }
}