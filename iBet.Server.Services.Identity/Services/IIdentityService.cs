using iBet.Server.Services.Identity.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace iBet.Server.Services.Identity.Services
{
    public interface IIdentityService
    {
        string GenerateJwtToken(string userId, string userName, string secret);
        Task<IdentityResult> CreateAsync(User user, string password);
        Task<User> FindByNameAsync(string userName);
        Task<bool> CheckPasswordAsync(User user, string password);
    }
}
