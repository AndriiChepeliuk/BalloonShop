using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BalloonShop.Models.BalloonType;

public class BalloonTypeConfiguration : IEntityTypeConfiguration<BalloonTypeModel>
{
    public void Configure(EntityTypeBuilder<BalloonTypeModel> builder)
    {
        builder
            .HasMany(balloonType => balloonType.LatexBalloons)
            .WithOne(latexBalloon => latexBalloon.ProductType)
            .HasForeignKey(latexBalloon => latexBalloon.ProductTypeId);
        builder
            .HasMany(balloonType => balloonType.FoilBalloons)
            .WithOne(foilBalloon => foilBalloon.ProductType)
            .HasForeignKey(foilBalloon => foilBalloon.ProductTypeId);
        builder
            .Ignore(balloonType => balloonType.Image);
    }
}
