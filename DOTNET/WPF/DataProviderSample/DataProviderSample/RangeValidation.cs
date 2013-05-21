using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace DataProviderSample
{
    public class RangeValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            int age = Convert.ToInt32(value);
            if (age < 18 || age > 60 )
            {
                return new ValidationResult(false, "value should be in the range of 18 to 60");
            }
            return new ValidationResult(true, "Succeed");

        }
    }
}
