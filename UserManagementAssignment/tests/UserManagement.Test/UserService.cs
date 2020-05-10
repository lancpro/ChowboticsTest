using NUnit.Framework;
using UserManagement.Repositories;
using UserManagement.SDK;

namespace UserManagement.Test
{
    public class UserService
    {
        private Services.UserService _userService;

        [SetUp]
        public void Setup()
        {
            //ToDo: create your own in-memory data for testing
            //Right now I am using the existing in-memory data
            var userRepository = new InMemoryUserRepository();
            _userService = new Services.UserService(userRepository);
        }

        [Test]
        [TestCase("ashishrathi")]
        [TestCase("kaustubhphanse")]
        [TestCase("bharatpatil")]
        [TestCase("prajaktasathe")]
        public void UserNameAlreadyExists(string userName)
        {
            var result = _userService.IsUserNameAlreadyExists(userName);
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("testashishrathi")]
        [TestCase("testkaustubhphanse")]
        [TestCase("testbharatpatil")]
        [TestCase("testprajaktasathe")]
        public void UserNameNotExists(string userName)
        {
            var result = _userService.IsUserNameAlreadyExists(userName);
            Assert.IsFalse(result);
        }

        [Test]
        [TestCase("ashish2rathi@gmail.com")]
        [TestCase("kaustubh.phanse@chowbotics.com")]
        [TestCase("bharat.patil@chowbotics.com")]
        [TestCase("Prajakta.Sathe@chowbotics.com")]
        public void EmailIdAlreadyExists(string emailID)
        {
            var result = _userService.IsEmailIdAlreadyExists(emailID);
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("ashish2rathi@test.com")]
        [TestCase("kaustubh.phanse@test.com")]
        [TestCase("bharat.patil@test.com")]
        [TestCase("Prajakta.Sathe@test.com")]
        public void EmailIdNotExists(string emailID)
        {
            var result = _userService.IsEmailIdAlreadyExists(emailID);
            Assert.IsFalse(result);
        }

        [Test]
        [TestCase("ashishrathi", "ashish@1234")]
        [TestCase("kaustubhphanse", "kaustubh@1234")]
        [TestCase("bharatpatil", "bharatp@1234")]
        [TestCase("prajaktasathe", "prajaktas@1234")]
        public void ValidUser(string userName, string password)
        {
            var result = _userService.IsValidUser(userName, password);
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("testashishrathi", "test@1234")]
        [TestCase("testkaustubhphanse", "test@1234")]
        [TestCase("testbharatpatil", "test@1234")]
        [TestCase("testprajaktasathe", "test@1234")]
        public void InvalidUser(string userName, string password)
        {
            var result = _userService.IsValidUser(userName, password);
            Assert.IsFalse(result);
        }

        [Test]
        [TestCase("testinguser1", "test1Password@123", "test1@test.com")]
        [TestCase("testinguser2", "test2Password@123", "test2@test.com")]
        [TestCase("testinguser3", "tes3tPassword@123", "test3@test.com")]
        public void AddUser(string username, string password, string emailId)
        {
            var user = new User(username, password, emailId);
            _userService.AddUser(user);
            Assert.IsTrue(_userService.IsUserNameAlreadyExists(username));
            Assert.IsTrue(_userService.IsEmailIdAlreadyExists(emailId));
        }

    }
}
