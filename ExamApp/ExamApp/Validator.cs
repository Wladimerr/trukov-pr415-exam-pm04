using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public static class Validator
    {
        public static bool ValidateAuthor(string text)
        {
            if (text.Length < 20 || text.Length > 75)
                return false;
            
            return true;
        }

        public static bool ValidateName(string text)
        {
            if (text.Length < 10 || text.Length > 100)
                return false;

            return true;
        }

        public static bool ValidateYear(string text)
        {
            int year = -1;
            try
            {
                year = Convert.ToInt32(text);
            }
            catch
            {
                return false;
            }
            if (year < 1000 || year > 9999)
                return false;

            return true;
        }
    }
}
