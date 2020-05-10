using System;

namespace UserManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProvideChoices();
        }

        public static void ProvideChoices()
        {
            Console.WriteLine();
            Console.WriteLine("Please select any one option:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            var userChoice = Console.ReadLine();
            ValidateChoice(userChoice);
        }

        private static void ValidateChoice(string userChoice)
        {
            switch (userChoice)
            {
                case "1":
                    Login.Start();
                    break;
                case "2":
                    Register.Start();
                    break;
                case "3":
                    //We can handle exit in better way
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please enter 1, 2 or 3 as your choice");
                    ProvideChoices();
                    break;
            }
        }
    }
}