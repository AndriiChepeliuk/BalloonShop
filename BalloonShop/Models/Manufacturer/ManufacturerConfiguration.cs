using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BalloonShop.Models.Manufacturer;

public class ManufacturerConfiguration : IEntityTypeConfiguration<ManufacturerModel>
{
    public void Configure(EntityTypeBuilder<ManufacturerModel> builder)
    {
        builder
            .HasMany(manufacturer => manufacturer.LatexBalloons)
            .WithOne(latexBalloon => latexBalloon.Manufacturer)
            .HasForeignKey(latexBalloon => latexBalloon.ManufacturerId);
        builder
            .HasMany(manufacturer => manufacturer.FoilBalloons)
            .WithOne(foilBalloon => foilBalloon.Manufacturer)
            .HasForeignKey(foilBalloon => foilBalloon.ManufacturerId);
    }
}
