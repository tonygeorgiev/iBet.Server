using iBet.Server.Services.Identity.Data;
using iBet.Server.Services.Identity.Data.Entities;
using iBet.Server.Services.Identity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iBet.Server.Services.Identity.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IdentityApplicationDbContext context;

        public ProfileService(IdentityApplicationDbContext applicationDbContext)
        {
            this.context = applicationDbContext;
        }

        public async Task<ProfileServiceModel> ByUser(string userId)
                    => await this.context
                        .Users
                        .Where(u => u.Id == userId)
                        .Select(u => 
                             new ProfileServiceModel
                            {
                                Name = u.Profile.Name,
                                MainPhotoUrl = u.Profile.MainPhotoUrl,
                                Biography = u.Profile.Biography,
                                Gender = u.Profile.Gender.ToString()
                            })
                        .FirstOrDefaultAsync();

        public async Task<Result> Update(Guid Id, string name, string mainPhotoUrl, string biography, Gender gender)
        {
            var userProfile = await this.context
                .Profiles
                .FirstOrDefaultAsync(p => p.Id == Id);

            if (userProfile == null)
            {
                return "User does not exist.";
            }

            if (userProfile.Name != name)
            {
                userProfile.Name = name;
            }

            if (userProfile.MainPhotoUrl != mainPhotoUrl)
            {
                userProfile.MainPhotoUrl = mainPhotoUrl;
            }

            if (userProfile.Biography != biography)
            {
                userProfile.Biography = biography;
            }

            if (userProfile.Gender != gender)
            {
                userProfile.Gender = gender;
            }

            await this.context.SaveChangesAsync();

            return true;
        }


    }
}
