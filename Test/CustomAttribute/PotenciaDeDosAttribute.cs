using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test.CustomAttribute
{
    public class PotenciaDeDosAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var valor = (int)value;
            var ceil = Math.Ceiling(Math.Log(valor, 2));
            var floor = Math.Floor(Math.Log(valor, 2));

            if (ceil == floor)
            {
                return true;
            }

            return false;
        }
    }
}
