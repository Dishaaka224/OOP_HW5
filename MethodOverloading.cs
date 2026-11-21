using System;
namespace Models;

class ReportPrinter
{
    public void Print(string title)
{
    Console.WriteLine(title);
}

    public void Print(string title, decimal total)
    {
        Console.WriteLine($"{title}: {total} so‘m");
    }

}
internal class CsvReportExporter : ReportExporter
{
    public override void Export(string data)
    {
        Console.WriteLine($"Hisobot CSV formatida eksport qilindi: {data}");
    }
}

internal class PdfReportExporter : ReportExporter
{
    public override void Export(string data)
    {
        Console.WriteLine($"Hisobot PDF formatida eksport qilindi: {data}");
    }
}