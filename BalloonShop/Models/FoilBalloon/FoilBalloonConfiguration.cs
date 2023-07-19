using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BalloonShop.Models.FoilBalloon;

public class FoilBalloonConfiguration : IEntityTypeConfiguration<FoilBalloonModel>
{
    public void Configure(EntityTypeBuilder<FoilBalloonModel> builder)
    {
        builder
            .HasOne(foilBalloon => foilBalloon.ProductType)
            .WithMany(productType => productType.FoilBalloons)
            .HasForeignKey(foilBalloon => foilBalloon.ProductTypeId);
        builder
            .HasOne(foilBalloon => foilBalloon.Color)
            .WithMany(color => color.FoilBalloons)
            .HasForeignKey(foilBalloon => foilBalloon.ColorId);
        builder
            .HasOne(foilBalloon => foilBalloon.Manufacturer)
            .WithMany(manufacturer => manufacturer.FoilBalloons)
            .HasForeignKey(foilBalloon => foilBalloon.ManufacturerId);
        builder
            .HasOne(foilBalloon => foilBalloon.Material)
            .WithMany(material => material.FoilBalloons)
            .HasForeignKey(foilBalloon => foilBalloon.MaterialId);
    }
}
