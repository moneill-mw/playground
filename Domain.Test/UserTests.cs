using NUnit.Framework;

namespace Domain.Test
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void CanCreateUser()
        {
            var user = new User();
            Assert.That(user, Is.Not.Null);
        }
    }
}
