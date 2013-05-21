using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Collections.Generic;

namespace CustomValidation.MVC
{
  public class FutureDateValidatorAttribute : ValidationAttribute, IClientValidatable
  {
    public override bool IsValid(object value)
    {
      return value != null && (DateTime)value > DateTime.Now;
    }

    public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
    {
      yield return new ModelClientValidationRule
      {         
        ErrorMessage = ErrorMessage,
        ValidationType = "futuredate"
      };
    }
  }
}