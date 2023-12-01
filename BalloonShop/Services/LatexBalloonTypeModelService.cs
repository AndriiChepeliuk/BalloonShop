using BalloonShop.Data;
using BalloonShop.Helpers;
using BalloonShop.Models.LatexBalloonType;
using System.Collections.Generic;
using System.Linq;

namespace BalloonShop.Services;

public class LatexBalloonTypeModelService
{
    public static void AddLatexBalloonType(LatexBalloonTypeModel latexBalloonType)
    {
        if (latexBalloonType != null)
        {
            using (var context = new ApplicationContext())
            {
                context.AddAsync(latexBalloonType);
                context.SaveChangesAsync();
            }
        }
    }

    public static List<LatexBalloonTypeModel> GetAllLatexBalloonTypes()
    {
        using (var context = new ApplicationContext())
        {
            var latexBalloonTypes = context.LatexBalloonTypes.OrderBy(x => x.Name).ToList();

            foreach (var latexBalloonType in latexBalloonTypes)
            {
                latexBalloonType.Image = ImageHelper.ConvertByteArrayToBitmapImage(latexBalloonType.ImageByteCode);
            }

            return latexBalloonTypes;
        }
    }
}
