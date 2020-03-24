using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

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


        


    }
}
