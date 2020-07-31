﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace VintageStuff.Web.Models
{
    public class EdicionRol
    {
        public IdentityRole Rol { get; set; }
        public IEnumerable<IdentityUser> Miembros { get; set; }
        public IEnumerable<IdentityUser> NoMiembros { get; set; }
    }
}