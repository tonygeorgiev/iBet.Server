using iBet.Server.Data.Models;
using iBet.Server.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iBet.Server.Services
{
    public interface IIdentityService
    {
        string GenerateJwtToken(string userId, string userName, string secret);
        Task<IdentityResult> CreateAsync(User user, string password);
        Task<User> FindByNameAsync(string userName);
        Task<bool> CheckPasswordAsync(User user, string password);
    }
}
