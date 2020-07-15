using System;
using System.Collections.Generic;
using System.Text;
using iBet.Server.Services.Identity.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace iBet.Server.Services.Identity.Data
{
    public class IdentityApplicationDbContext : IdentityDbContext<User>
    {
        public IdentityApplicationDbContext(DbContextOptions<IdentityApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
