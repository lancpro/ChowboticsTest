namespace UserManagement.Services
{
    //This class consist of validation - Client side validation for registration form when it is web app
    //Added this functionality in separate class so that we can write test case for them
    public class LoginService
    {
        //Just checking is null or empty
        //This is kind of client side validation, but written in service class to write test cases.
        public bool IsValidUsername(string userName)
        {
            return !string.IsNullOrWhiteSpace(userName);
        }

        public bool IsValidPassword(string Password)
        {
            return !string.IsNullOrWhiteSpace(Password);
        }
    }
}
