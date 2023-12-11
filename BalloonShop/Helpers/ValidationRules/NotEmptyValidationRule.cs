using System.Globalization;
using System.Windows.Controls;

namespace BalloonShop.Helpers.ValidationRules;

public class NotEmptyValidationRule : ValidationRule
{
    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        return string.IsNullOrWhiteSpace((value ?? "").ToString())
            ? new ValidationResult(false, "Це поле має бути заповнене!")
            : ValidationResult.ValidResult;
    }
}
