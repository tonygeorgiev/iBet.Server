using iBet.Server.Services.Identity.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iBet.Server.Services.Identity.Models
{
    public class UpdateProfileRequestModel
    {
        public Guid Id { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }

        public string MainPhotoUrl { get; set; }

        [MaxLength(150)]
        public string Biography { get; set; }

        public Gender Gender { get; set; }
    }
}
