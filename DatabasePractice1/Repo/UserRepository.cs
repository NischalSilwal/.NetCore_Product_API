using DatabasePractice1.Models;
using DatabasePractice1.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DatabasePractice1.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> Authenticate(string username, string password)
        {
            // Assuming password is stored in plain text for simplicity (use hashing in production)
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
        }

        public async Task RegisterUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
