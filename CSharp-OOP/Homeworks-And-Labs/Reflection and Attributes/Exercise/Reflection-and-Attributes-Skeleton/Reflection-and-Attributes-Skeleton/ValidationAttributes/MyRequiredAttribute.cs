﻿using System;
using System.Linq;

namespace ValidationAttributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {

        public override bool IsValid(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            return true;
        }
    }
}
