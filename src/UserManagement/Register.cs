using System;
using System.Runtime.InteropServices;
using UserManagement.Services;

namespace UserManagement
{
    public class Register
    {
        private static readonly RegisterService _registerService;

        static Register()
        {
            _registerService = new RegisterService();
        }
        public static void Start()
        {
            Console.WriteLine("Please, enter an email-id");
            var emailId = Console.ReadLine();
            ValidateEmailId(emailId);

            Console.WriteLine("Please, enter an user name");
            var userName = Console.ReadLine();
            ValidateUserName(userName);

            Console.WriteLine("Please, enter a password");
            var password = Console.ReadLine();
            ValidatePassword(password);
        }

        private static void ValidateEmailId(string emailId)
        {
            if (!_registerService.IsValidEmailID(emailId))
            {
                //print email id rules
                Console.WriteLine("Please enter valid mail id");
                ValidatePassword(Console.ReadLine());
            }
        }

        private static void ValidatePassword(string password)
        {
            if (!_registerService.IsValidPassword(password))
            {
                //print password rules
                Console.WriteLine("Please enter valid password");
                ValidatePassword(Console.ReadLine());
            }
        }

        private static void ValidateUserName(string userName)
        {
            if (!_registerService.IsValidUsername(userName))
            {
                //print user name rules
                Console.WriteLine("Please enter valid user name");
                ValidateUserName(Console.ReadLine());
            }
        }

    }
}
