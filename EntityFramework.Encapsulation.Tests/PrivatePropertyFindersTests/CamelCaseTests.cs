using System;
using EntityFramework.Encapsulation.Conventions.PrivatePropertyFinders;
using EntityFramework.Encapsulation.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFramework.Encapsulation.Tests.PrivatePropertyFindersTests
{
    [TestClass]
    public class CamelCaseTests
    {
        private readonly CamelCaseFinder _finder = new CamelCaseFinder();

        [TestMethod]
        public void CamelCase_Should_Change_Firstname_To_firstname()
        {
            var output = _finder.Find("Firstname");

            Assert.AreEqual(output,"firstname");
        }

        [TestMethod]
        public void CamelCase_Should_Change_OfficePhone_To_officePhone()
        {
            var output = _finder.Find("OfficePhone");

            Assert.AreEqual(output, "officePhone");
        }

        [TestMethod]
        public void CamelCase_Should_Raise_InvalidConventionException_On_firstname()
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
            catch (Exception ex)
            {
                Assert.Fail();
            }

        }
    }
}
