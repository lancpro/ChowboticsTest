using NUnit.Framework;
using UserManagement.Repositories;
using UserManagement.Services;

namespace UserManagement.Test
{
    public class Password
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
        [TestCase("Abcdgf@1234")]
        [TestCase("abD_1234")]
        [TestCase("TesTPas#89")]
        [TestCase("TesT8 2#215")]
        public void ValidPassword(string password)
        {
            var result = _registerService.IsValidPassword(password);
            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("Af@14")]
        [TestCase("aD_1")]
        [TestCase("TesT89254215")]
        [TestCase("TeT#89")]
        [TestCase("asbcgsdhkjsd")]
        [TestCase("1235468765")]
        [TestCase("asds23sdgg")]
        public void InvalidPassword(string password)
        {
            var result = _registerService.IsValidPassword(password);
            Assert.IsFalse(result);
        }
    }
}
