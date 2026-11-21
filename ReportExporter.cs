using System;
namespace Model;

internal class ReportExporter
{
    public virtual void Export(string data)
    {
        Console.WriteLine($"Hisobot umumiy formatda eksport qilindi: {data}");
    }
}

internal class PdfReportExporter : ReportExporter
{
    public override void Export(string data)
    {
        Console.WriteLine($"Hisobot PDF formatida eksport qilindi: {data}");
    }
}

internal class CsvReportExporter : ReportExporter
{
    public override void Export(string data)
    {
        Console.WriteLine($"Hisobot CSV formatida eksport qilindi: {data}");
    }
}