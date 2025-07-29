using UserAPI.Models;
using UserAPI.Repositories;

namespace UserAPI.Services
{
    public class UserService : IUserService

    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<User> CreateUser(User user)
        {
            var commentTemp = new User()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Status = user.Status,
                Id = user.Id
            };
            return await _userRepository.CreateUser(commentTemp);
        }
    }
}
