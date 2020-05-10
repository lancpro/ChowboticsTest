using System;
using UserManagement.Repositories;
using UserManagement.Services;

namespace UserManagement
{
    //Kind of client side UI code
    public class Login
    {
        private static readonly LoginService _loginService;
        private static readonly UserService _userService;

        static Login()
        {
            var userRepository = new InMemoryUserRepository();
            _loginService = new LoginService();
            _userService = new UserService(userRepository);
        }

        public static void Start()
        {
            Console.WriteLine(Message.EnterUserName);
            var userName = Console.ReadLine();
            ValidateUserName(userName);

            Console.WriteLine(Message.EnterPassword);
            var password = Console.ReadLine();
            ValidatePassword(password);

            var validationMessage = _userService.IsValidUser(userName, password)
                ? Message.ValidUser
                : Message.InvalidUser;

            Console.WriteLine(validationMessage);
            Program.ProvideChoices();
        }

        private static void ValidatePassword(string password)
        {
            if (!_loginService.IsValidPassword(password))
            {
                Console.WriteLine(Message.EnterValidPassword);
                ValidatePassword(Console.ReadLine());
            }
        }

        private static void ValidateUserName(string userName)
        {
            if (!_loginService.IsValidUsername(userName))
            {
                Console.WriteLine(Message.EnterValidUserName);
                ValidateUserName(Console.ReadLine());
            }
        }
    }
}