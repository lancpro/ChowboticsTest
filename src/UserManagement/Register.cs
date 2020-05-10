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
            _registerService = new RegisterService(userRepository);
            _userService = new UserService(userRepository);
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

            AddUser(userName, password, emailId);
            Program.ProvideChoices();
        }

        private static void ValidateEmailId(string emailId)
        {
            if (!_registerService.IsValidEmailID(emailId))
            {
                //print email id rules
                Console.WriteLine("Please enter valid mail id");
                ValidateEmailId(Console.ReadLine());
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

        private static void AddUser(string userName, string password, string emailId)
        {
            var user = new User(userName, password, emailId);
            _userService.AddUser(user);
            Console.WriteLine("User registered successfully!");
        }
    }
}
