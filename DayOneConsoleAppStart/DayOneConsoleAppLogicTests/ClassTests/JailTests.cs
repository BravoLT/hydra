using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOneConsoleAppLogic;

namespace DayOneConsoleAppLogicTests
{
    [TestClass]
    public class JailTests
    {

        string tempName = "Other Matt";
        string tempEvilPower = "Technical Writing... and shit";
        string tempEmblem = "Flat things";
        string tempPrimaryColor = "Blue";
        string tempSecondaryColor = "White";
        Villain testVillain;
        Jail testJail;

        [TestInitialize]
        public void CreateOurTestVillain()
        {
            testVillain = new Villain(tempName, tempEvilPower, tempEmblem, tempPrimaryColor, tempSecondaryColor);
            testJail = new Jail();
        }
        
        [TestMethod]
        public void CanAddVillainsToJail()
        {
            testJail.PlaceVillain(testVillain);

            Assert.IsNotNull(testJail.ArrayForJail[0]);
            Assert.IsNull(testJail.ArrayForJail[1]);
            
        }

        [TestMethod]
        public void VerifyVillainArrayIsNotNull()
        {
            testJail.PlaceVillain(testVillain);
            Assert.IsNotNull(testJail);
            Assert.IsNotNull(testJail.ArrayForJail);

        }

    }
}
