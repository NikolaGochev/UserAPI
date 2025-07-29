using UserAPI.Models;

namespace UserAPI.Services
{
    public interface IUserService
    {


        Task<List<User>> GetUsers();
       Task<User> CreateUser(User user);
    }
}
