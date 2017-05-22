using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using ValidationEngine;

namespace ValidationEngineTests
{
    [TestFixture]
    public class ValidationTests
    {
        
        [Test]
        public void TrueForValidAddress()
        {
            //Arrange
            var sut = new Validator();
            string mail = "name@test.com";

            //Act
            bool res= sut.ValidateEmailAddress(mail);

            //Assert
            Assert.IsTrue(res, "The email is working.");

        }

        [Test]
        public void TrueForValidAddress2()
        {
            //Arrange
            var sut = new Validator();
            string mail = "name@testcom";

            //Act
            bool res = sut.ValidateEmailAddress(mail);

            //Assert
            Assert.IsTrue(res, "The email is working.");

        }

        [Test]
        public void TrueForValidAddress3()
        {
            //Arrange
            var sut = new Validator();
            string mail = "nametest.com";

            //Act
            bool res = sut.ValidateEmailAddress(mail);

            //Assert
            Assert.IsTrue(res, "The email is working.");

        }

        [Test]
        public void TrueForValidAddress4()
        {
            //Arrange
            var sut = new Validator();
            string mail = "name123@test.com";

            //Act
            bool res = sut.ValidateEmailAddress(mail);

            //Assert
            Assert.IsTrue(res, "The email is working.");

        }

        [Test]
        public void TrueForValidAddress5()
        {
            //Arrange
            var sut = new Validator();
            string mail = "name@test123.com";

            //Act
            bool res = sut.ValidateEmailAddress(mail);

            //Assert
            Assert.IsTrue(res, "The email is working.");

        }


    }
}
