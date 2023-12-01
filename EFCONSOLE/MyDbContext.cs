using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DATABASE;

public class MyDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public MyDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseMySql(
            "server=localhost;database=testef;user=root;password=",
            ServerVersion.AutoDetect("server=localhost;database=testef;user=root;password=")
        );
    }
}
