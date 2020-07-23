using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iBet.Server.Controllers.Base;
using iBet.Server.Services.Identity.Models;
using iBet.Server.Services.Identity.Services;
using Microsoft.AspNetCore.Mvc;

namespace iBet.Server.Services.Identity.Controllers
{
    public class ProfileController : ApiController
    {
        private readonly IProfileService profiles;
        private readonly ICurrentUserService currentUser;

        public ProfileController(
            IProfileService profiles,
            ICurrentUserService currentUser)
        {
            this.profiles = profiles;
            this.currentUser = currentUser;
        }

        [HttpGet]
        [Route(nameof(Mine))]
        public async Task<ProfileServiceModel> Mine()
            => await this.profiles.ByUser(this.currentUser.GetId());



        [HttpPut]
        [Route(nameof(Update))]
        public async Task<ActionResult> Update(UpdateProfileRequestModel model)
        {   
            var result = await this.profiles.Update(
                model.Id,
                model.Name,
                model.MainPhotoUrl,
                model.Biography,
                model.Gender);

            if (result.Failure)
            {
                return BadRequest(result.Error);
            }

            return Ok();
        }
    }
}
