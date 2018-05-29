using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOneConsoleAppLogic;

namespace DayOneConsoleAppLogicTests
{
    [TestClass]
    public class GarageTests
    {
        Garage testGarage;
        private int numberOfStalls = 2;
        Car JacobsHoopty;
        Car MatthewsRide;
        Car OtherMattsWheels;
        Segway WeberMobile;
        Bus BussyMcBusFace;
        Truck Truckster;
        Motorcycle CrotchRocket;

        [TestInitialize]
        public void Initialize()
        {
            testGarage = new Garage(numberOfStalls);
            JacobsHoopty = new Car("White", 1, 5, 4, 6, 16.3f);
            MatthewsRide = new Car("Charcoal", 1, 5, 4, 6, 13.2f);
            OtherMattsWheels = new Car("Emerald", 2, 4, 4, 4, 15.0f);
            WeberMobile = new Segway("Orange", 1, 1, 2, 0, 1f);
            BussyMcBusFace = new Bus("Yellow", 8, 40, 4, 42, 56.2f);
            Truckster = new Truck("Purple", 1, 2, 18, 3, 5.8f);
            CrotchRocket = new Motorcycle("Red", 1, 2, 2, 0, 8.0f);
        }

        [TestMethod]
        public void VerifyOneVehicleMayBeAdded()
        {
            testGarage.AcceptVehicleInGarage(JacobsHoopty);
            Assert.IsNotNull(testGarage.Vehicles[0]);
            Assert.IsNull(testGarage.Vehicles[1]);
        }

        [TestMethod]
        public void VerifyTwoVehicesMayBeAdded()
        {
            testGarage.AcceptVehicleInGarage(JacobsHoopty);
            testGarage.AcceptVehicleInGarage(BussyMcBusFace);
            Assert.IsNotNull(testGarage.Vehicles[0]);
            Assert.IsNotNull(testGarage.Vehicles[1]);
        }

        [TestMethod]
        public void VerifyVehiclesAreUnique()
        {
            testGarage.AcceptVehicleInGarage(JacobsHoopty);
            testGarage.AcceptVehicleInGarage(BussyMcBusFace);
            Assert.IsTrue(testGarage.Vehicles[0] != testGarage.Vehicles[1]);
        }

        [TestMethod]
        public void VerifyGarageCannotExceedStallLimit()
        {
            numberOfStalls = 6;
            testGarage = new Garage(numberOfStalls);
            testGarage.AcceptVehicleInGarage(JacobsHoopty);
            testGarage.AcceptVehicleInGarage(Truckster);
            testGarage.AcceptVehicleInGarage(WeberMobile);
            testGarage.AcceptVehicleInGarage(CrotchRocket);
            testGarage.AcceptVehicleInGarage(BussyMcBusFace);
            testGarage.AcceptVehicleInGarage(MatthewsRide);
            testGarage.AcceptVehicleInGarage(OtherMattsWheels);
            
            Assert.IsNotNull(testGarage.Vehicles[0]);
            Assert.IsNotNull(testGarage.Vehicles[1]);
            Assert.IsNotNull(testGarage.Vehicles[2]);
            Assert.IsNotNull(testGarage.Vehicles[3]);
            Assert.IsNotNull(testGarage.Vehicles[4]);
            Assert.IsNotNull(testGarage.Vehicles[5]);
        }
    }
}
