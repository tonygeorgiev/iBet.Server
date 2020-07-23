﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace iBet.Server.Services.Identity.Infrastructure.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetId(this ClaimsPrincipal user)
            => user
                .Claims
                .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)
                ?.Value;
    }
}
