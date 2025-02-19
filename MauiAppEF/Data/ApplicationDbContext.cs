using Microsoft.EntityFrameworkCore;

namespace MauiAppEF.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Blog> Blogs { get; set; }

    public ApplicationDbContext()
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Maui;Trusted_Connection=True;MultipleActiveResultSets=true");
    }
}
