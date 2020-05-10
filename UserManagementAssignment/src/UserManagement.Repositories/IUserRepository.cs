using UserManagement.SDK;

namespace UserManagement.Repositories
{

    //We can take this interface as a part of separate project as well
    // like UserManagement.Boundaries

    public interface IUserRepository
    {
        bool IsUserNameAlreadyExists(string userName);
        bool IsEmailIdAlreadyExists(string emailId);
        bool IsValidUser(string userName, string password);
        void AddUser(User user);
    }
}
