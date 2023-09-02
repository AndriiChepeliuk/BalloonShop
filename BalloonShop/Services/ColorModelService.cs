using BalloonShop.Data;
using BalloonShop.Models.Color;

namespace BalloonShop.Services;

public class ColorModelService
{
    public static void AddColor(ColorModel color)
    {
        using (var context = new ApplicationContext())
        {
            context.Colors.Add(color);
            context.SaveChanges();
        }
    }
}
