using NUnit.Framework;
using UserManagement.Repositories;
using UserManagement.Services;

namespace UserManagement.Test
{
    public class EmailId
    {
        private RegisterService _registerService;

        [SetUp]
        public void Setup()
        {
            //To-Do: create your own in-memory data for testing
            //Right now I am using the existing in-memory data
            var userRepository = new InMemoryUserRepository();
            _registerService = new RegisterService(userRepository);
        }

        [Test]
        [TestCase("david.jones@proseware.com")]
        [TestCase("d.j@server1.proseware.com")]
        [TestCase("jones@ms1.proseware.com")]
        [TestCase("j@proseware.com9")]
        [TestCase("js#internal@proseware.com")]
        [TestCase("j_9@[129.126.118.1]")]
        [TestCase("js@proseware.com9")]
        [TestCase("j.s@server1.proseware.com")]
        public void ValidEmailIds(string emailId)
        {
            var result = _registerService.IsValidEmailID(emailId);
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("j.@server1.proseware.com")]
        [TestCase("j..s@proseware.com")]
        [TestCase("js*@proseware.com")]
        [TestCase("js@proseware..com")]
        public void InvalidEmailIds(string emailId)
        {
            var result = _registerService.IsValidEmailID(emailId);
            Assert.IsFalse(result);
        }
    }
}