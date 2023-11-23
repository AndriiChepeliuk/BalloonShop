using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BalloonShop.Models.LatexBalloonType;

public class LatexBalloonTypeConfiguration : IEntityTypeConfiguration<LatexBalloonTypeModel>
{
    public void Configure(EntityTypeBuilder<LatexBalloonTypeModel> builder)
    {
        builder
            .HasMany(balloonType => balloonType.LatexBalloons)
            .WithOne(latexBalloon => latexBalloon.LatexBalloonType)
            .HasForeignKey(latexBalloon => latexBalloon.LatexBalloonTypeId);
        builder
            .Ignore(balloonType => balloonType.Image);
    }
}
