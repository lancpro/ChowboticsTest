using System;
using UserManagement.Repositories;
using UserManagement.SDK;
using UserManagement.Services;

namespace UserManagement
{
    public class Register
    {
        private static readonly RegisterService _registerService;
        private static readonly UserService _userService;

        static Register()
        {
            var userRepository = new InMemoryUserRepository();
            _registerService = new RegisterService();
            _userService = new UserService(userRepository);
        }

        public static void Start()
        {
            Console.WriteLine(Message.EnterEmailID);
            var emailId = Console.ReadLine();
            ValidateEmailId(emailId);

            Console.WriteLine(Message.EnterUserName);
            var userName = Console.ReadLine();
            ValidateUserName(userName);

            Console.WriteLine(Message.EnterPassword);
            var password = Console.ReadLine();
            ValidatePassword(password);

            AddUser(userName, password, emailId);
            Program.ProvideChoices();
        }

        private static void ValidateEmailId(string emailId)
        {
            if (!_registerService.IsValidEmailID(emailId))
            {
                Console.WriteLine(Message.EnterValidEmailID);
                ValidateEmailId(Console.ReadLine());
            }

            if (_userService.IsEmailIdAlreadyExists(emailId))
            {
                Console.WriteLine(Message.EmailIDAlreadyExists);
                ValidateEmailId(Console.ReadLine());
            }
        }

        private static void ValidatePassword(string password)
        {
            if (!_registerService.IsValidPassword(password))
            {
                Console.WriteLine(Message.PasswordRules.ToString());
                Console.WriteLine(Message.EnterValidPassword);
                ValidatePassword(Console.ReadLine());
            }
        }

        private static void ValidateUserName(string userName)
        {
            if (!_registerService.IsValidUsername(userName))
            {
                //print user name rules
                Console.WriteLine(Message.EnterValidUserName);
                ValidateUserName(Console.ReadLine());
            }

            if (_userService.IsUserNameAlreadyExists(userName))
            {
                Console.WriteLine(Message.UserNameAlreadyExists);
                ValidateUserName(Console.ReadLine());
            }
        }

        private static void AddUser(string userName, string password, string emailId)
        {
            var user = new User(userName, password, emailId);
            _userService.AddUser(user);
            Console.WriteLine(Message.UserRegistered);
        }
    }
}
