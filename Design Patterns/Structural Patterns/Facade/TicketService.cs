namespace Design_Patterns.Structural_Patterns.Facade;
public class TicketService : ITicketService
{
    private readonly IFileStorageService _fileStorageService;

    public TicketService(IFileStorageService fileStorageService)
    {
        _fileStorageService = fileStorageService;
    }

    public void Create()
    {
        _fileStorageService.UploadFile("/Imagem/Ticket", "arcondicionado.jpg");
    }
}

