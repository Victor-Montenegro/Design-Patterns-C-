namespace Design_Patterns.Structural_Patterns.Facade;
public class GoogleStorage : IGoogleStorage
{
    public void UploadFile(GoogleFileInfo googleFileInfo)
    {
        Console.WriteLine("Upload do arquivo Google");
    }
}

