﻿using iBet.Server.Services.Identity.Data.Entities.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iBet.Server.Services.Identity.Data.Entities
{
    public class User : IdentityUser, IEntity
    {
        public Profile Profile { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public string ModifiedBy { get; set; }
    }
}
