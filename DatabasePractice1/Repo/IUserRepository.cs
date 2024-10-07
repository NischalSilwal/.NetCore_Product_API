using DatabasePractice1.Models;
using System.Threading.Tasks;

namespace DatabasePractice1.Repo
{
    public interface IUserRepository
    {
        Task<User> Authenticate(string username, string password);
        Task RegisterUserAsync(User user);
    }
}
