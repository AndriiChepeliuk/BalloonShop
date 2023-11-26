using BalloonShop.Data;
using BalloonShop.Helpers;
using BalloonShop.Models.LatexBalloon;
using BalloonShop.Models.LatexBalloonType;
using System.Collections.Generic;
using System.Linq;

namespace BalloonShop.Services;

public class LatexBalloonModelService
{
    public static void AddLatexBalloon(LatexBalloonModel latexBalloon)
    {
        if (latexBalloon == null)
        {
            using (var context = new ApplicationContext())
            {
                context.LatexBalloons.AddAsync(latexBalloon);
                context.SaveChanges();
            }
        }
    }

    public static List<LatexBalloonModel> GetAllLatexBalloons()
    {
        using (var context = new ApplicationContext())
        {
            var latexBalloons = context.LatexBalloons.OrderBy(x => x.Name).ToList();

            foreach (var latexballoon  in latexBalloons)
            {
                latexballoon.Image = ImageHelper.ConvertByteArrayToBitmapImage(latexballoon.ImageByteCode);
            }

            return latexBalloons;
        }
    }

    public static List<LatexBalloonModel> GetLatexBalloonsWithSpecificType(LatexBalloonTypeModel latexBalloonType)
    {
        using (var context = new ApplicationContext())
        {
            var dbLatexBalloonType = context.LatexBalloonTypes.Find(latexBalloonType);

            var latexBalloons = context.LatexBalloons.Where(x => x.LatexBalloonType == dbLatexBalloonType).OrderBy(x => x.Name).ToList();

            foreach (var latexballoon in latexBalloons)
            {
                latexballoon.Image = ImageHelper.ConvertByteArrayToBitmapImage(latexballoon.ImageByteCode);
            }

            return latexBalloons;
        }
    }
}
