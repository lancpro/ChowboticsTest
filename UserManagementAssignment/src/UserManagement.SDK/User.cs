namespace UserManagement.SDK
{
    public class User
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string EmailId { get; private set; }

        public User(string userName, string password, string emailId)
        {
            UserName = userName;
            Password = password;
            EmailId = emailId;
        }
    }
}