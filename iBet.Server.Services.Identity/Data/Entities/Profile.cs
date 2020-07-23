using iBet.Server.Services.Identity.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iBet.Server.Services.Identity.Data.Entities
{
    public class Profile : Entity<Guid>
    {
        public Profile()
        {
            this.Id = Guid.NewGuid();
        }

        [MaxLength(40)]
        public string Name { get; set; }

        public string MainPhotoUrl { get; set; }

        [MaxLength(150)]
        public string Biography { get; set; }

        public Gender Gender { get; set; }

        public string UserId { get; set; }
        
        public User User { get; set; }
    }
}
