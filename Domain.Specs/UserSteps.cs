using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Domain.Specs
{
    [Binding]
    public class UserSteps
    {
        private string _username;
        private User _user;
        [Given(@"a username of ""(.*)""")]
        public void GivenAUsernameOf(string p0)
        {
            _username = p0;
        }
        
        [When(@"I create a User")]
        public void WhenICreateAUser()
        {
            _user = new User(_username);
        }
        
        [Then(@"the username should be ""(.*)""")]
        public void ThenTheUsernameShouldBe(string p0)
        {
            Assert.That(_user.Name, Is.EqualTo(_username));
        }
    }
}
