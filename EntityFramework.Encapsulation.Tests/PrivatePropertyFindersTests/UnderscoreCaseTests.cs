using System;
using EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders;
using EntityFramework.Encapsulation.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFramework.Encapsulation.Tests.PrivatePropertyFindersTests
{
    [TestClass]
    public class UnderscoreCaseTests
    {
        private readonly UnderscoreCaseFinder _finder = new UnderscoreCaseFinder();

        [TestMethod]
        public void UnderscoreCase_Should_Should_Raise_InvalidConventionException_On_Firstname()
        {
            try
            {
                var output = _finder.Find("Firstname");
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
        public void UnderscoreCase_Should_Change_OfficePhone_To_Office_Phone()
        {
            var output = _finder.Find("OfficePhone");

            Assert.AreEqual(output, "Office_Phone");
        }

        [TestMethod]
        public void UnderscoreCase_Should_Change_OfficePhone_To_office_Phone()
        {
            var output = _finder.Find("officePhone");

            Assert.AreEqual(output, "office_Phone");
        }
    }
}
