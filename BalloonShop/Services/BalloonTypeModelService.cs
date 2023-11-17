using BalloonShop.Data;
using BalloonShop.Helpers;
using BalloonShop.Models.LatexBalloonType;
using System.Collections.Generic;
using System.Linq;

namespace BalloonShop.Services;

public class BalloonTypeModelService
{
    public static void AddProductType(LatexBalloonTypeModel productType)
    {
        if (productType != null)
        {
            using (var context = new ApplicationContext())
            {
                context.AddAsync(productType);
                context.SaveChangesAsync();
            }
        }
    }

    public static List<LatexBalloonTypeModel> GetAllBalloonTypes()
    {
        using (var context = new ApplicationContext())
        {
            var balloonTypes = context.LatexBalloonTypes.OrderBy(x => x.Name).ToList();

            foreach (var balloonType in balloonTypes)
            {
                balloonType.Image = ImageHelper.ConvertByteArrayToBitmapImage(balloonType.ImageByteCode);
            }

            return balloonTypes;
        }
    }
}
