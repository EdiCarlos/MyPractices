using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Xml;

namespace MvcValidation.Models
{

    public class PasswordModels 
    {
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [ValidateLength]
        public string Password { get; set; }
        

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [ValidateLength]
        public string ConfirmPassword { get; set; }

    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple=false, Inherited=false)]
    public sealed class ValidateLengthAttribute : ValidationAttribute, IClientValidatable
    {
        private const string _defaultErrorMessage = "{0} must be at least {1} character long";
        private readonly int _minCharacter = 5;

        public ValidateLengthAttribute() : base(_defaultErrorMessage)
        {

        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(CultureInfo.CurrentCulture, ErrorMessageString, name, _minCharacter.ToString());
        }
        public override bool IsValid(object value)
        {
            string valueAsString = value as string;
            return (valueAsString != null && valueAsString.Length >= _minCharacter);
        }

        #region IClientValidatable Members

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = FormatErrorMessage(metadata.DisplayName),
                ValidationType = "validatelength"
            };
        }

        #endregion
    }
}