using System;
using UserManagement.Services;

namespace UserManagement
{
    public class Login
    {
        private static readonly LoginService _loginService;
        private static readonly UserService _userService;

        static Login()
        {
            _loginService = new LoginService();
            _userService = new UserService();
        }

        //Kind of client side UI code
        public static void Start()
        {
            Console.WriteLine("Please, enter a user name");
            var userName = Console.ReadLine();
            ValidateUserName(userName);

            Console.WriteLine("Please, enter a password");
            var password = Console.ReadLine();
            ValidatePassword(password);

            var validationMessage = _userService.IsValidUser(userName, password)
                ? "Valid User"
                : "Invalid user";

            Console.WriteLine(validationMessage);
            Program.ProvideChoices();
        }

        private static void ValidatePassword(string password)
        {
            if (!_loginService.IsValidPassword(password))
            {
                Console.WriteLine("Password should not be empty, please enter valid password");
                ValidatePassword(Console.ReadLine());
            }
        }

        private static void ValidateUserName(string userName)
        {
            if (!_loginService.IsValidUsername(userName))
            {
                Console.WriteLine("User name should not be empty, please enter valid user name");
                ValidateUserName(Console.ReadLine());
            }
        }
    }
}