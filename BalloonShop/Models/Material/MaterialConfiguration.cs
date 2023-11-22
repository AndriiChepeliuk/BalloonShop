using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BalloonShop.Models.Material;

public class MaterialConfiguration : IEntityTypeConfiguration<MaterialModel>
{
    public void Configure(EntityTypeBuilder<MaterialModel> builder)
    {
        //builder
        //    .HasMany(material => material.LatexBalloons)
        //    .WithOne(latexBalloon => latexBalloon.Material)
        //    .HasForeignKey(latexBalloon => latexBalloon.MaterialId);
        builder
            .HasMany(material => material.FoilBalloons)
            .WithOne(foilBalloon => foilBalloon.Material)
            .HasForeignKey(foilBalloon => foilBalloon.MaterialId);
    }
}
