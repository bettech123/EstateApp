
using EstateApp.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Estate.Data.DatabaseContexts.AuthenticationDbContext
{
    public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
       public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
            : base(options)
            {

            }
    }
}