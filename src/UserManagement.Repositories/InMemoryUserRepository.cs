using System.Collections.Generic;
using System.Linq;
using UserManagement.SDK;

namespace UserManagement.Repositories
{

    //There could be multiple implementation user repository interface like SQL/Mongo repository
    //For now I am using in memory data
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users;

        public InMemoryUserRepository()
        {
            _users = new List<User>
            {
                new User(userName: "ashishrathi", password: "ashish@1234", emailId: "ashish2rathi@gmail.com"),
                new User(userName: "kaustubhphanse", password: "kaustubh@1234", emailId: "kaustubh.phanse@chowbotics.com"),
                new User(userName: "bharatpatil", password: "bharatp@1234", emailId: "bharat.patil@chowbotics.com"),
                new User(userName: "prajaktasathe", password: "prajaktas@1234", emailId: "Prajakta.Sathe@chowbotics.com")
            };
        }

        public bool IsUserNameAlreadyExists(string userName)
        {
            return _users.Any(user => user.UserName == userName);
        }

        public bool IsEmailIdAlreadyExists(string emailId)
        {
            return _users.Any(user => user.EmailId == emailId);
        }

        public bool IsValidUser(string userName, string password)
        {
            return _users.Any(
                user => user.UserName == userName && user.Password == password);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}
