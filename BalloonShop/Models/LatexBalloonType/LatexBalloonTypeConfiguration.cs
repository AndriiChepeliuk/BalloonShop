using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BalloonShop.Models.LatexBalloonType;

public class LatexBalloonTypeConfiguration : IEntityTypeConfiguration<LatexBalloonTypeModel>
{
    public void Configure(EntityTypeBuilder<LatexBalloonTypeModel> builder)
    {
        builder
            .HasMany(balloonType => balloonType.LatexBalloons)
            .WithOne(latexBalloon => latexBalloon.ProductType)
            .HasForeignKey(latexBalloon => latexBalloon.ProductTypeId);
        builder
            .Ignore(balloonType => balloonType.Image);
    }
}
