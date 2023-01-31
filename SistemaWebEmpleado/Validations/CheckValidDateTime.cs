﻿using System.ComponentModel.DataAnnotations;

namespace OperaWebSitee.Validations
{
    public class CheckValidDateTime : ValidationAttribute
    {
        public CheckValidDateTime() 
        {
            ErrorMessage = "El año debe ser Mayor o igual a 2000";
        }
        public override bool IsValid(object value)
        {
            int year = (int)value;
            if (year <= 2000)
            {
                return false;

            }
            else
            {
                return true;
            }

        }
    }
}