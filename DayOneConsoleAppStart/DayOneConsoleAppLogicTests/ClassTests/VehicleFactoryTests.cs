using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOneConsoleAppLogic;

namespace DayOneConsoleAppLogicTests
{
    [TestClass]
    public class VehicleFactoryTests
    {
        Address testAddress;
        VehicleFactory testFactory;
        string name = "BravoFactory";
        string street = "660 Cascade Hills Rd";
        string city = "Grand Rapids";
        string state = "MI";
        string zip = "49534";
        string selectedColor = "Purple";
        

        [TestInitialize]
        public void Initialize()
        {
            testAddress = new Address(street, city, state, zip);
            testFactory = new VehicleFactory(name, testAddress);
        }

        [TestMethod]
        public void VerifyFactoryIsNotNullAndCorrect()
        {
            Assert.IsNotNull(testFactory);
            Assert.IsNotNull(testFactory.Name);
            Assert.IsNotNull(testFactory.Address);

            Assert.IsTrue(testFactory.Name == name);
            Assert.IsTrue(testFactory.Address == testAddress);
        }

        [TestMethod]
        public void VerifySimpleCar()
        {
            Vehicle simpleCar = testFactory.CreateSimpleCar();
            Assert.IsNotNull(simpleCar);
            Assert.IsTrue(simpleCar.Color == VehicleFactory.DefaultColor);
            Assert.IsTrue(simpleCar.NumberOfPassengers == VehicleFactory.DefaultPassengers);
            Assert.IsTrue(simpleCar.MaxCapacity == VehicleFactory.DefaultCapacity);
            Assert.IsTrue(simpleCar.NumberOfWheels == VehicleFactory.DefaultNumberOfTires);
            Assert.IsTrue(simpleCar.NumberOfWindows == VehicleFactory.DefaultNumberOfWindows);
            Assert.IsTrue(simpleCar.FuelCapacity == VehicleFactory.DefaultGasCapacity);
        }

        [TestMethod]
        public void VerifyPaintedCar()
        {
            Vehicle paintedCar = testFactory.CreatePaintedCar(selectedColor);
            Assert.IsNotNull(paintedCar);
            Assert.IsTrue(paintedCar.Color == selectedColor);
            Assert.IsTrue(paintedCar.NumberOfPassengers == VehicleFactory.DefaultPassengers);
            Assert.IsTrue(paintedCar.MaxCapacity == VehicleFactory.DefaultCapacity);
            Assert.IsTrue(paintedCar.NumberOfWheels == VehicleFactory.DefaultNumberOfTires);
            Assert.IsTrue(paintedCar.NumberOfWindows == VehicleFactory.DefaultNumberOfWindows);
            Assert.IsTrue(paintedCar.FuelCapacity == VehicleFactory.DefaultGasCapacity);
        }

        [TestMethod]
        public void VerifyDeluxeCar()
        {
            int extraSeats = 2;
            float extraGasCapacity = 4f;
            Vehicle deluxeCar = testFactory.CreateDeluxeCar(selectedColor, extraSeats, extraGasCapacity);
            Assert.IsNotNull(deluxeCar);
            Assert.IsTrue(deluxeCar.Color == selectedColor);
            Assert.IsTrue(deluxeCar.NumberOfPassengers == VehicleFactory.DefaultPassengers);
            Assert.IsTrue(deluxeCar.MaxCapacity == (VehicleFactory.DefaultCapacity + extraSeats));
            Assert.IsTrue(deluxeCar.NumberOfWheels == VehicleFactory.DefaultNumberOfTires);
            Assert.IsTrue(deluxeCar.NumberOfWindows == VehicleFactory.DefaultNumberOfWindows);
            Assert.IsTrue(deluxeCar.FuelCapacity == (VehicleFactory.DefaultGasCapacity + extraGasCapacity));
        }

        [TestMethod]
        public void VehicleFactoryDefaultColorIsNotNull()
        {
            Assert.IsNotNull(VehicleFactory.DefaultColor);
        }

        [TestMethod]
        public void VehicleFactoryDefaultNumPassengersIsCorrect()
        {
            Assert.IsTrue(VehicleFactory.DefaultPassengers == 0);
        }

        [TestMethod]
        public void VehicleFactoryDefaultMaxCapacityIsCorrect()
        {
            Assert.IsTrue(VehicleFactory.DefaultCapacity == 4);
        }

        [TestMethod]
        public void VehicleFactoryDefaultNumOfWindowsIsCorrect()
        {
            Assert.IsTrue(VehicleFactory.DefaultNumberOfWindows == 6);
        }

        [TestMethod]
        public void VehicleFactoryDefaultNumOfTiresIsCorrect()
        {
            Assert.IsTrue(VehicleFactory.DefaultNumberOfTires == 4);
        }

        [TestMethod]
        public void VehicleFactoryDefaultGasCapacityIsCorrect()
        {
            Assert.IsTrue(VehicleFactory.DefaultGasCapacity == 8f);
        }

    }
}
