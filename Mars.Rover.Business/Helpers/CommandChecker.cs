using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mars.Rover.Business.Helpers
{
    public class CommandChecker
    {
   
        public static bool IsValidCommand(string inputEmail)
        {
            string strRegex = "[lrmLRM]+";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
}
