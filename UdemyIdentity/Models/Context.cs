using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UdemyIdentity.Models;
public class Context : IdentityDbContext<AppUser>
{
    public Context(DbContextOptions<Context> options) : base(options) { }
}
