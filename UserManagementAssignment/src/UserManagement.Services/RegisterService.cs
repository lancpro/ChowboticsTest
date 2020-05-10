using System;
using System.Collections.Generic;
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
            var isUserNameRulesMatches =
                !string.IsNullOrWhiteSpace(userName) //Non-empty string
                && userName.Length >= 8              //Should have minimum 8 char
                && userName.All(ch => Char.IsLetterOrDigit(ch) || ch == '_'); //Should only contain char/digit and underscore

            return isUserNameRulesMatches;
        }

        public bool IsValidPassword(string password)
        {
            var specialCharacters = new List<char> { '!', '@', '#', '$', '*', '-', '_' };
            var isPasswordRuleMatch =
                !string.IsNullOrWhiteSpace(password) // Non-empty
                && password.Length >= 8 // Minimum 8 word password
                && password.ToCharArray().Any(ch => Char.IsLetter(ch)) //Atleaset one character
                && password.ToCharArray().Any(ch => Char.IsDigit(ch)) //Atlease one digit
                && password.ToCharArray().Any(ch => specialCharacters.Contains(ch)); //Atleast one special character

            return isPasswordRuleMatch;
        }

        public bool IsValidEmailID(string emailId)
        {
            var emailIdRegex =
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            var isEmailRuleMatches =
                !string.IsNullOrWhiteSpace(emailId) //Not null or empty string
                && Regex.IsMatch(emailId, emailIdRegex, RegexOptions.IgnoreCase); //Valid email syntax

            return isEmailRuleMatches;
        }
    }
}