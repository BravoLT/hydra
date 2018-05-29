using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOneConsoleAppLogic;

namespace DayOneConsoleAppLogicTests
{
    [TestClass]
    public class VillainTests
    {
        Villain testVillain;
        string name = "Mojo Jojo";
        string evilPower = "shooting laser beams from butt";
        string emblem = "brain with eyes";
        string primaryColor = "Purple";
        string secondaryColor = "White";
        int victims = 3;
        string location = "Metropolis";
        string weapon = "ray gun";
        string crimeCommitted = "Pony Wrangling";

        [TestInitialize]
        public void Initialize()
        {
            testVillain = new Villain(name, evilPower, emblem, primaryColor, secondaryColor); 
        }

        [TestMethod]
        public void NameIsNotNullAndExpectedValue()
        {
            Assert.IsNotNull(testVillain.Name);
            Assert.IsTrue(testVillain.Name == name,"No dice " + testVillain.Name);
        }
        [TestMethod]
        public void EvilPowerIsNotNullAndExpectedValue()
        {
            Assert.IsNotNull(testVillain.EvilPower);
            Assert.IsTrue(testVillain.EvilPower == evilPower, "No dice " + testVillain.EvilPower);
        }
        [TestMethod]
        public void EmblemIsNotNullAndExpectedValue()
        {
            Assert.IsNotNull(testVillain.Emblem);
            Assert.IsTrue(testVillain.Emblem == emblem, "No dice " + testVillain.Emblem);
        }
        [TestMethod]
        public void PrimaryColorIsNotNullAndExpectedValue()
        {
            Assert.IsNotNull(testVillain.PrimaryColor);
            Assert.IsTrue(testVillain.PrimaryColor == primaryColor, "No dice " + testVillain.PrimaryColor);
        }
        [TestMethod]
        public void SecondaryColorIsNotNullAndExpectedValue()
        {
            Assert.IsNotNull(testVillain.SecondaryColor);
            Assert.IsTrue(testVillain.SecondaryColor == secondaryColor, "No dice " + testVillain.SecondaryColor);
        }
        [TestMethod]
        public void DoEvilIsNotNull()
        {
            Assert.IsNotNull(testVillain.DoEvil(victims,location,weapon,crimeCommitted),testVillain.DoEvil(victims, location, weapon, crimeCommitted));
        }
    }
}
