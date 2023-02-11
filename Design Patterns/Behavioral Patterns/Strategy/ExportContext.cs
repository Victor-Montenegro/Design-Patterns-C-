namespace Design_Patterns.Behavioral_Patterns.Strategy;
public class ExportContext
{
    private readonly ExportStrategy _exportStrategy;

    public ExportContext(ExportStrategy exportStrategy)
    {
        _exportStrategy = exportStrategy;
    }

    public void ExportFile(string fileName)
    {
        _exportStrategy.ExportFile(fileName);
    }
}

