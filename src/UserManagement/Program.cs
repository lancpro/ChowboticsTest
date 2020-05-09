using System;

namespace UserManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ProvideChoices();
            Console.ReadKey();
        }

        static void ProvideChoices()
        {
            Console.WriteLine("Please select any one option:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            var userChoice = Console.ReadLine();
            ValidateChoice(userChoice);
        }

        static void ValidateChoice(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    var login = new Login();
                    break;
                case "2":
                    var register = new Register();
                    break;
                default:
                    ProvideChoices();
                    break;
            }
        }
    }
}