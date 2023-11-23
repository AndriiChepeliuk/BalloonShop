using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BalloonShop.Models.LatexBalloon;

public class LatexBalloonConfiguration : IEntityTypeConfiguration<LatexBalloonModel>
{
    public void Configure(EntityTypeBuilder<LatexBalloonModel> builder)
    {
        builder
            .HasOne(latexBalloon => latexBalloon.LatexBalloonType)
            .WithMany(productType => productType.LatexBalloons)
            .HasForeignKey(latexBalloon => latexBalloon.LatexBalloonTypeId);
        builder
            .Ignore(latexBalloon => latexBalloon.Image);
        //builder
        //    .HasOne(latexBalloon => latexBalloon.Color)
        //    .WithMany(color => color.LatexBalloons)
        //    .HasForeignKey(latexBalloon => latexBalloon.ColorId);
        //builder
        //    .HasOne(latexBalloon => latexBalloon.Manufacturer)
        //    .WithMany(manufacturer => manufacturer.LatexBalloons)
        //    .HasForeignKey(latexBalloon => latexBalloon.ManufacturerId);
        //builder
        //    .HasOne(latexBalloon => latexBalloon.Material)
        //    .WithMany(material => material.LatexBalloons)
        //    .HasForeignKey(latexBalloon => latexBalloon.MaterialId);
    }
}
