namespace WebAppMVC2;

public class InMemoryUserRepository : IUserRepository
{
    private readonly List<string> users = new List<string>();
    
    public IEnumerable<string> Users => users;

    public void Add(string user)
    {
        users.Add(user);
    }
    
}