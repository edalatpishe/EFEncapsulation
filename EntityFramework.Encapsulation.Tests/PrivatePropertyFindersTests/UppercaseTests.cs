using System;
using EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders;
using EntityFramework.Encapsulation.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFramework.Encapsulation.Tests.PrivatePropertyFindersTests
{
    [TestClass]
    public class UppercaseTests
    {
        private readonly UppercaseFinder _finder = new UppercaseFinder();

        [TestMethod]
        public void Uppercase_Should_Should_Raise_InvalidConventionException_On_FIRSTNAME()
        {
            try
            {
                var output = _finder.Find("FIRSTNAME");
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
        public void Uppercase_Should_Change_OfficePhone_To_OFFICEPHONE()
        {
            var output = _finder.Find("OfficePhone");

            Assert.AreEqual(output, "OFFICEPHONE");
        }

        [TestMethod]
        public void Uppercase_Should_Change_firstname_To_FIRSTNAME()
        {
            var output = _finder.Find("firstname");

            Assert.AreEqual(output, "FIRSTNAME");
        }
    }
}
