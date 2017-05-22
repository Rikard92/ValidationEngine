using System;
using System.Linq;

namespace ValidationEngine
{
    public class Validator
    {
        public Validator()
        {

        }

        public bool ValidateEmailAddress(string mail)
        {
            if (mail == null)
            {
                return false;
            }

            if (mail.Contains(".")&&mail.Contains("@"))
            {
            
                string[] split1 = mail.Split('@');
                string fh = split1[0];
                string sh = split1[1];

                if (fh.Contains(".") )
                {
                    return false;
                }
                if (fh.Any(char.IsDigit))
                {
                    return false;
                }

            if (sh.Any(char.IsDigit))
            {
                return false;
            }

            return true;
            }
            return false;
        }

        
    }
}