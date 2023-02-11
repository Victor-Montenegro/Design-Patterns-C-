namespace Design_Patterns.Behavioral_Patterns.Strategy;
public class ExcelExport : ExportStrategy
{
    public override void ExportFile(string fileName)
    {
        Console.WriteLine($"Exportando Arquivo: {fileName}.xls");
    }
}

