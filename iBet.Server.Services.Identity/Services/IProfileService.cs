using iBet.Server.Services.Identity.Data.Entities;
using iBet.Server.Services.Identity.Models;
using System;
using System.Threading.Tasks;

namespace iBet.Server.Services.Identity.Services
{
    public interface IProfileService
    {
        Task<ProfileServiceModel> ByUser(string userId);

        Task<Result> Update(
            Guid Id,
            string name,
            string mainPhotoUrl,
            string biography,
            Gender gender);
    }
}