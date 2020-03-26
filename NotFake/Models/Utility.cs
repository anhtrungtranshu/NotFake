using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace NotFake.Models
{
    public class Utility
    {
        public static bool IsEmailValid(string Email)
        {
            try
            {
                MailAddress m = new MailAddress(Email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static string ValidationErrorsTooltip(ModelErrorCollection errors)
        {
            return String.Join("",errors.Select(str => String.Format("<div>{0}</div>",str.ErrorMessage)));
        }
    }
}
