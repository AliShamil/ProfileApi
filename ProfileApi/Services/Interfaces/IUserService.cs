

using ProfileApi.Models;
using ProfileApi.Models.DTO;

namespace ProfileApi.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> RegisterAsync(RegisterDTO model);
        Task<bool> LoginAsync(LoginDTO model);
        public Task<User?> FindUserByEmailAsync(string email);
    }
}
