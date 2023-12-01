using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BalloonShop.Models.Color;

public class ColorConfiguration : IEntityTypeConfiguration<ColorModel>
{
    public void Configure(EntityTypeBuilder<ColorModel> builder)
    {
        //builder
        //    .HasMany(color => color.LatexBalloons)
        //    .WithOne(latexBalloon => latexBalloon.Color)
        //    .HasForeignKey(latexBalloon => latexBalloon.ColorId);
        builder
            .HasMany(color => color.FoilBalloons)
            .WithOne(foilBalloon => foilBalloon.Color)
            .HasForeignKey(foilBalloon => foilBalloon.ColorId);
    }
}
