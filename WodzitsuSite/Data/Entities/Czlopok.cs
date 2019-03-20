using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WodzitsuSite.Data.Entities
{
    public class Czlopok : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
