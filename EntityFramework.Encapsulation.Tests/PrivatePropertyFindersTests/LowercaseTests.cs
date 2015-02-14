using System;
using EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders;
using EntityFramework.Encapsulation.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFramework.Encapsulation.Tests.PrivatePropertyFindersTests
{
    [TestClass]
    public class LowercaseTests
    {
        private readonly LowercaseFinder _finder = new LowercaseFinder();

        [TestMethod]
        public void Lowercase_Should_Should_Raise_InvalidConventionException_On_firstname()
        {
            try
            {
                var output = _finder.Find("firstname");
                Assert.Fail();

            }
            catch (InvalidConventionException ex)
            {
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Lowercase_Should_Change_OfficePhone_To_officephone()
        {
            var output = _finder.Find("OfficePhone");

            Assert.AreEqual(output, "officephone");
        }

        [TestMethod]
        public void Lowercase_Should_Change_Firstname_To_firstname()
        {
            var output = _finder.Find("Firstname");

            Assert.AreEqual(output, "firstname");
        }
    }
}
