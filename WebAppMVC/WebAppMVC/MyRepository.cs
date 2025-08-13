namespace WebAppMVC;

public class MyRepository : IRepository
{
    private readonly ILogger<MyRepository> _logger;

    public MyRepository(ILogger<MyRepository> logger)
    {
        this._logger = logger;
    }
    public string GetById(string id)
    {
        return "ID: " + id;
    }
}