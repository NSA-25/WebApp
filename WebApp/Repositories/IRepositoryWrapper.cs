namespace WebApp.Repositories
{   
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        Task SaveAsync();
    }
}
