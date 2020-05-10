using UserManagement.Repositories;
using UserManagement.SDK;

namespace UserManagement.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool IsUserNameAlreadyExists(string userName)
        {
            return _userRepository.IsUserNameAlreadyExists(userName);
        }

        public bool IsEmailIdAlreadyExists(string emailId)
        {
            return _userRepository.IsEmailIdAlreadyExists(emailId);
        }

        public bool IsValidUser(string userName, string password)
        {
            return _userRepository.IsValidUser(userName, password);
        }

        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }
    }
}