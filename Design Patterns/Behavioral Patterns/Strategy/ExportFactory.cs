namespace Design_Patterns.Behavioral_Patterns.Strategy;
public class ExportFactory
{
    public static ExportStrategy CreateExport(TypeExport typeExport)
    {
        switch (typeExport)
        {
            case TypeExport.Excel: return new ExcelExport();
            case TypeExport.Xml: return new XmlExport();
            case TypeExport.Pdf: return new PdfExport();
            default: throw new Exception("Exportação inválida");
        }
    }
}

