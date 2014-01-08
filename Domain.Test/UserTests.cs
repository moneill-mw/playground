﻿using NUnit.Framework;
using System;

namespace Domain.Test
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void CanCreateUser()
        {
            string name = "marko";
            var user = new User(name);
            Assert.That(user, Is.Not.Null);
            Assert.That(user.Name, Is.EqualTo(name));
        }

        [Test]
        public void CannotCreateNullUser()
        {
            Assert.Throws<ArgumentNullException>(() => new User(null));
        }
    }
}
