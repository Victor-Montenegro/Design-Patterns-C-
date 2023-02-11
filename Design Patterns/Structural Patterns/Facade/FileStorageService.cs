namespace Design_Patterns.Structural_Patterns.Facade;

//Facade
public class FileStorageService : IFileStorageService
{
    private readonly IGoogleStorage _googleStorage;

    public FileStorageService(IGoogleStorage googleStorage)
    {
        _googleStorage = googleStorage;
    }

    public void UploadFile(string filePath, string fileName)
    {
        var googleFileInfo = new GoogleFileInfo
        {
            Name = fileName,
            Path = filePath,
        };

        Console.WriteLine("Facade - Meio de campo entre o google storage");

        _googleStorage.UploadFile(googleFileInfo);
    }
}

