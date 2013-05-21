
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomValidation.MVC.Models
{
  public class Party : IValidatableObject
  {
    [Required(ErrorMessage = "Start date is required")]
    [FutureDateValidator(ErrorMessage = "Start date should be a future date")]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "Duration is required")]    
    public int DurationInHours { get; set; }

    [Required(ErrorMessage = "No. of joinees is required")]
    [Range(2, 10, ErrorMessage = "No. of joinees should be minimum 2 and not more than 10")]
    public int NoOfJoinees { get; set; }    

    public bool Drinks { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (StartDate.TimeOfDay > new TimeSpan(22 - DurationInHours, 0, 0))
      {
        yield return new ValidationResult("The party should not exceed after 10.00 PM");
      }

      if (NoOfJoinees < 5 && Drinks)
      {
        yield return new ValidationResult("Drinks are only allowed if no. of joinees is 5 or more.");
      }
    }
  }
}