using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.Neo4j;
using Microsoft.AspNetCore.Identity;

namespace IdentitySample.Mvc.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : Neo4jIdentityUser
    {
    }
}
