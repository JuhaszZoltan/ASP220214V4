using ASP220214V4.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP220214V4.Models
{
    public class Nagykoru : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Ugyfel ugyfel = null;

            if (validationContext.ObjectInstance is Ugyfel)
                ugyfel = (Ugyfel)validationContext.ObjectInstance;
            else ugyfel = Mapper.Map((UgyfelDto)validationContext.ObjectInstance, ugyfel);

            if (ugyfel.ElofizetesTipusId == ElofizetesTipus.Bronze)
                return ValidationResult.Success;

            if (ugyfel.SzuletesiDatum is null)
                return new ValidationResult("A születési dátumodat meg kell adnod!");

            return DateTime.Now.AddYears(-18) >= ugyfel.SzuletesiDatum
                ? ValidationResult.Success
                : new ValidationResult("nagykorúnak kell lenned ehhez az előfizetői csomaghoz");
        }
    }
}