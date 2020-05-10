using System.Linq.Expressions;
using System.Text;

namespace UserManagement
{
    //TODO: You can move this message into resource file and keep them in separate projects
    //This might be helpful for localization in web applications
    public static class Message
    {
        static Message()
        {
            PasswordRules = new StringBuilder();
            PasswordRules.AppendLine("Password:");
            PasswordRules.AppendLine("1. Should not be empty");
            PasswordRules.AppendLine("2. Should have minimum 8 character");
            PasswordRules.AppendLine("3. Contains at least one character");
            PasswordRules.AppendLine("4. Contains at least one digit");
            PasswordRules.AppendLine("5. Contains at least one special character");
        }

        public const string EnterUserName = "Please, enter username!";
        public const string EnterValidUserName = "Please, enter valid username!";
        public const string UserNameAlreadyExists = "Username already exists, please try with other username!";


        public static readonly StringBuilder PasswordRules;
        public const string EnterPassword = "Please, enter password!";
        public const string EnterValidPassword = "Please, enter valid password!";

        public const string EnterEmailID = "Please, enter email-id!";
        public const string EnterValidEmailID = "Please, enter valid email-id!";
        public const string EmailIDAlreadyExists = "Email-id already exists, please try with other email id!";


        public const string ValidUser = "Valid User!";
        public const string InvalidUser = "Invalid User!";

        public const string UserRegistered = "User registered successfully!";

    }
}
