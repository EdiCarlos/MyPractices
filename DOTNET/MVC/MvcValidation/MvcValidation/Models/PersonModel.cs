using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Reflection;

namespace MvcValidation.Models
{
    public class PersonModel
    {
        [Required]
        [Display(Name="Name")]
        [Remote("GetName", "Person", ErrorMessage="Name is not \"Arif\".")]
        public string Name { get; set; }

        [Required(ErrorMessage="Age is required")]
        [Display(Name="Age")]
        public int Age { get; set; }

        [OneOfTwoRequired("Mobile", ErrorMessage = "Must have atleast mobile or phone")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [OneOfTwoRequired("Phone", ErrorMessage="Must have atleast mobile or phone")]
        [Display(Name="Mobile")]
        public string Mobile { get; set; }

    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class OneOfTwoRequiredAttribute : ValidationAttribute, IClientValidatable
    {
        private const string _errorMessage = "{0} or {1} is required";

        private string otherProperty;

        public OneOfTwoRequiredAttribute(string PropertyName):base(_errorMessage)
        {
            if (string.IsNullOrEmpty(PropertyName))
            {
                throw new ArgumentNullException("otherProperty");
            }
            otherProperty = PropertyName;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, otherProperty);
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            PropertyInfo otherPropertyInfo = validationContext.ObjectInstance.GetType().GetProperty(otherProperty);
            if (otherPropertyInfo == null)
            {
                return new ValidationResult(string.Format("Property is '{0}' is unindentified", otherProperty));
            }
            var otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);
            if(otherPropertyValue == null && value == null)
            {
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            }
            return ValidationResult.Success;
        }
        #region IClientValidatable Members

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = FormatErrorMessage(metadata.DisplayName),
                ValidationType = "oneoftworequired"
            };
        }

        #endregion
    }
}