using Backend_DONT_USE.Models.DB;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Backend.Models.DB
{
    public class DbUser : IdentityUser<long>
    {
        public virtual ICollection<DbUserRole> UserRoles { get; set; }
    }
}
