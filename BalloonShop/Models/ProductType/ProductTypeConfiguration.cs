using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BalloonShop.Models.ProductType;

public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductTypeModel>
{
    public void Configure(EntityTypeBuilder<ProductTypeModel> builder)
    {
        builder
            .HasMany(productType => productType.LatexBalloons)
            .WithOne(latexBalloon => latexBalloon.ProductType)
            .HasForeignKey(latexBalloon => latexBalloon.ProductTypeId);
        builder
            .HasMany(productType => productType.FoilBalloons)
            .WithOne(foilBalloon => foilBalloon.ProductType)
            .HasForeignKey(foilBalloon => foilBalloon.ProductTypeId);
    }
}
