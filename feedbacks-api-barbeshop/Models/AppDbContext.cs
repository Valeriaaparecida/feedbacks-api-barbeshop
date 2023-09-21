using Microsoft.EntityFrameworkCore;
using feedbacks_api_barbeshop.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Feedback> Feedbacks { get; set; }
}
