using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Netserv1.Infrastructure.Models;

namespace Netserv1.Infrastructure;

public class Netserv1DbContext : IdentityDbContext<IdentityUser>
{
    public Netserv1DbContext(DbContextOptions<Netserv1DbContext> options)
        : base(options) { }

    public DbSet<MulyDbModel> Mulies { get; set; }
}
