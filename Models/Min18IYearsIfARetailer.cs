using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarfazahFashion.Models
{
    public class Min18IYearsIfARetailer : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.Customer)
                return ValidationResult.Success;

            if (customer.BirthDate == null)
                return new ValidationResult("Birth date field is required");

            var age = DateTime.Now.Year - customer.BirthDate.Value.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Retailer must be atleast 18");
        }
    }
}