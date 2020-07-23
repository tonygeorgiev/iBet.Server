using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iBet.Server.Services.Identity.Models
{
    public class ProfileServiceModel
    {
        public string Name { get; set; }
        public string MainPhotoUrl { get; set; }

        public string Biography { get; set; }
        public string Gender { get; set; }
    }
}
