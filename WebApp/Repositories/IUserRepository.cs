using WebApp.Data;
using WebApp.Entities;

namespace WebApp.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserById(int id);
        Task<User> GetByIdWithRoles(int id);
        public void Remove(User entity);
    }
}
