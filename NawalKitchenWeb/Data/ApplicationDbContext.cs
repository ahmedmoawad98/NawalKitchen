using Microsoft.EntityFrameworkCore;
using NawalKitchenWeb.Models;

namespace NawalKitchenWeb.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
}

