using BackEndTryitter.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndTryitter.Contexts;

public class TryitterContext : DbContext
{
    public TryitterContext(DbContextOptions<TryitterContext> options)
        : base(options)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Image> Images { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
        optionsBuilder.UseSqlServer(connectionString);
    }
}