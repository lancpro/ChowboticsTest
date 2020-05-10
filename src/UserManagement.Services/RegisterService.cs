using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace UserManagement.Services
{
    //This class consist of validation - Client side validation for registration form when it is web app
    //Added this functionality in separate class so that we can write test case for them
    public class RegisterService
    {
        public bool IsValidUsername(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return false;
            }
            else if (userName.Length <= 8)
            {
                return false;
            }
            else if (!userName.All(ch => Char.IsLetterOrDigit(ch) || ch == '_'))
            {
                return false;
            }
            //Is not null of empty - done
            //Has minimum character - done
            //does not contain special characters -done
            //Check for existing username
            return true;
        }

        public bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            else if (password.Length <= 8)
            {
                return false;
            }
            //Is not null of empty - Done
            //Has minimum character - Done
            //Match the password rules
            return true;
        }

        public bool IsValidEmailID(string emailId)
        {
            var emailIdRegex =
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (string.IsNullOrWhiteSpace(emailId))
            {
                return false;
            }
            else if (!Regex.IsMatch(emailId, emailIdRegex, RegexOptions.IgnoreCase))
            {
                return false;
            }
            //Is not null or Empty - Done
            //Is valid email id - Done
            //Is email id already exists
            return true;
        }
    }
}