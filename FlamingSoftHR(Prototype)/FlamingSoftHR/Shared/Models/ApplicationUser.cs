using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlamingSoftHR.Shared.Models
{
    public class ApplicationUser : IdentityUser
    { 
        public virtual ICollection<Employees> Employee { get; set; }
    }
}
