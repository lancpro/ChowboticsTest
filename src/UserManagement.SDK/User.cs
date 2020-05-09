namespace UserManagement.SDK
{
    public class User
    {
        public string UserName { get; set; } //Validate minimum length
        public string Password { get; set; } // Validate password length/no. char
        public string Email { get; set; } // Validate email address using regex
    }
}