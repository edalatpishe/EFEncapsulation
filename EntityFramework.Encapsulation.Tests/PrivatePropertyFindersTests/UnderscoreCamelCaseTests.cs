using System;
using EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders;
using EntityFramework.Encapsulation.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFramework.Encapsulation.Tests.PrivatePropertyFindersTests
{
    [TestClass]
    public class UnderscoreCamelCaseTests
    {
        private readonly UnderscoreCamelCaseFinder _finder = new UnderscoreCamelCaseFinder();

        [TestMethod]
        public void UnderscoreCamelCase_Should_Change_Firstname_To__firstname()
        {
            var output = _finder.Find("Firstname");

            Assert.AreEqual(output,"_firstname");
        }

        [TestMethod]
        public void UnderscoreCamelCase_Should_Change_OfficePhone_To_officePhone()
        {
            var output = _finder.Find("OfficePhone");

            Assert.AreEqual(output, "_officePhone");
        }

        [TestMethod]
        public void UnderscoreCamelCase_Should_Raise_InvalidConventionException_On__firstname()
        {
            try
            {
                var output = _finder.Find("_firstname");
                Assert.Fail();
            }
            catch (InvalidConventionException ex)
            {
                Assert.IsTrue(true);
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }
    }
}
