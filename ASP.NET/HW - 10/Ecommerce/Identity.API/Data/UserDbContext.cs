using Identity.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Identity.Data;

public class UserDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<ApplicationUser> users { get; set; }
    public UserDbContext() : base()
    {
        
    }

}
