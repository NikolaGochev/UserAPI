using UserAPI.Models;

namespace UserAPI.Repositories
{
    public interface IUserRepository

    {
        Task<List<User>> GetAllUsers();
        Task<User> CreateUser(User user);

    }
}
