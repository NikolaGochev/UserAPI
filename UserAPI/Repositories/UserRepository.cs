using Microsoft.EntityFrameworkCore;
using UserAPI.Data;
using UserAPI.Models;


namespace UserAPI.Repositories
{
    public class UserRepository : IUserRepository


    {
        private readonly UserDbContext _context;
        public UserRepository(UserDbContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        

        public async Task<User> CreateUser(User newUser)
        {
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }
    }
}
