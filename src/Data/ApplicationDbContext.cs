using Data.Todos;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions options) 
        : base(options)
    {
    }

    public DbSet<Todo> Todos { get; set; }
}
