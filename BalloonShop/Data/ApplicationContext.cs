using BalloonShop.Models.Color;
using BalloonShop.Models.FoilBalloon;
using BalloonShop.Models.LatexBalloon;
using BalloonShop.Models.Manufacturer;
using BalloonShop.Models.Material;
using BalloonShop.Models.BalloonType;
using Microsoft.EntityFrameworkCore;

namespace BalloonShop.Data;

public class ApplicationContext : DbContext
{
    public DbSet<LatexBalloonModel> LatexBalloons { get; set; }
    public DbSet<FoilBalloonModel> FoilBalloons { get; set; }
    public DbSet<ColorModel> Colors { get; set; }
    public DbSet<ManufacturerModel> Manufacturers { get; set; }
    public DbSet<MaterialModel> Materials { get; set; }
    public DbSet<BalloonTypeModel> BalloonTypes { get; set; }

    public ApplicationContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=../../../Data/BalloonShopDataDB.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new LatexBalloonConfiguration());
        modelBuilder.ApplyConfiguration(new FoilBalloonConfiguration());
        modelBuilder.ApplyConfiguration(new ColorConfiguration());
        modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
        modelBuilder.ApplyConfiguration(new MaterialConfiguration());
        modelBuilder.ApplyConfiguration(new BalloonTypeConfiguration());
    }
}
