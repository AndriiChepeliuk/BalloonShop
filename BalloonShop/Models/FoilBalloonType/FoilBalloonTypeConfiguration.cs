using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BalloonShop.Models.FoilBalloonType;

public class FoilBalloonTypeConfiguration : IEntityTypeConfiguration<FoilBalloonTypeModel>
{
    public void Configure(EntityTypeBuilder<FoilBalloonTypeModel> builder)
    {
        builder
            .HasMany(balloonType => balloonType.FoilBalloons)
            .WithOne(foilBalloon => foilBalloon.ProductType)
            .HasForeignKey(foilBalloon => foilBalloon.ProductTypeId);
        builder
            .Ignore(balloonType => balloonType.Image);
    }
}
