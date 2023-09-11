using EcommerceMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMVC.Data;

public class UserDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<ApplicationUser> users { get; set; }
    public UserDbContext() : base()
    {
        
    }

}
