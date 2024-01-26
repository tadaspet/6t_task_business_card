﻿using System.ComponentModel.DataAnnotations;

namespace _2._2012.IntroductionAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class CarTypeAttribute : ValidationAttribute
    {
        private readonly string[] validTypes = new string[] { "Sedan", "Coupe", "SUV", "Hatchback", "Station wagon", "Pickup truck", "Van" };
        public override bool IsValid(object? value)
        {
            var type = value as string;
            if (type == null)
            {
                return false;
            }
            var isValid = validTypes.Contains(type.ToLower());
            return isValid;
        }
    }
}
