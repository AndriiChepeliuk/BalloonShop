using BalloonShop.Data;
using BalloonShop.Models.BalloonType;

namespace BalloonShop.Services;

public class ProductTypeModelService
{
    public static void AddProductType(BalloonTypeModel productType)
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
}
