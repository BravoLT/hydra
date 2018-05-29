using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOneConsoleAppLogic;

namespace DayOneConsoleAppLogicTests
{
    [TestClass]
    public class AddressTests
    {
        private string street = "542 Hampton Lanes";
        private string city = "Walker";
        private string state = "MI";
        private string zip = "49534";
        Address testAddress;

        [TestInitialize]
        public void Initialize()
        {
            testAddress = new Address(street,city,state,zip);  
        }

        [TestMethod]
        public void VerifyAddressIsNotNull()
        {
            Assert.IsNotNull(testAddress);
        }

        [TestMethod]
        public void VerifyStreetIsCorrectAndNotNull()
        {
            Assert.IsNotNull(testAddress.Street);
            Assert.IsTrue(testAddress.Street == street);
        }
        [TestMethod]
        public void VerifyCityIsCorrectAndNotNull()
        {
            Assert.IsNotNull(testAddress.City);
            Assert.IsTrue(testAddress.City == city);
        }
        [TestMethod]
        public void VerifyStateAbbrevIsCorrectAndNotNull()
        {
            Assert.IsNotNull(testAddress.State);
            Assert.IsTrue(testAddress.State == state);
        }
        [TestMethod]
        public void VerifyZipIsCorrectAndNotNull()
        {
            Assert.IsNotNull(testAddress.Zip);
            Assert.IsTrue(testAddress.Zip == zip);
        }
    }
}
