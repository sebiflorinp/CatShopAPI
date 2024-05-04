using CatShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CatShopAPI.Contexts;

public class CatDbContext : DbContext
{
    public DbSet<Cat?> Cats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("Server=roundhouse.proxy.rlwy.net;Database=railway;Port=36232;Uid=root;Pwd=dOrlZctonxrzoWaUGBMUlbWkIRLaFnqd;");
    }
}