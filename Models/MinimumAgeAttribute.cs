﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationHW1.Models
{
    public class MinimumAgeAttribute : ValidationAttribute 
    {
        int _minAge;

        public MinimumAgeAttribute(int minimumAge)
        {
            _minAge = minimumAge;
        }

        public override bool IsValid(object value)
        {
            DateTime date;
            if (DateTime.TryParse(value.ToString(), out date))
            {
                return date.AddYears(_minAge) < DateTime.Now;
            }

            return false;
        }
    }
}
