using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{

    /*
     * Look at villain class, and think about feeding the villains
     * The jail has to feed them
     * the villains would have to have a boolean status of "IsHungry" that can be flipped
     * 
     * make unit tests and properties
     * */

    public class VehicleFactory
    {
        #region privateFields
        private string name;
        private Address address;
        #endregion privateFields

        #region PublicFields
        public const string DefaultColor = "White";
        public const int DefaultPassengers = 0;
        public const int DefaultCapacity = 4;
        public const int DefaultNumberOfTires = 4;
        public const int DefaultNumberOfWindows = 6;
        public const float DefaultGasCapacity = 8f;
        #endregion PublicFields

        #region PublicProperties
        public string Name
        {
            get { return name; }
        }
        public Address Address
        {
            get { return address; }
        }
        #endregion PublicProperties

        #region Methods
        public VehicleFactory(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public Vehicle CreateSimpleCar()
        {
            Vehicle simpleVehicle = new Car(DefaultColor, DefaultPassengers, DefaultCapacity, DefaultNumberOfTires, DefaultNumberOfWindows, DefaultGasCapacity);
            return simpleVehicle;
        }

        public Vehicle CreatePaintedCar(string selectedColor)
        {
            Vehicle paintedCar = new Car(selectedColor, DefaultPassengers, DefaultCapacity, DefaultNumberOfTires, DefaultNumberOfWindows, DefaultGasCapacity);
            return paintedCar;
        }

        public Vehicle CreateDeluxeCar(string selectedColor, int extraSeats, float extraGasCapacity)
        {
            Vehicle deluxeCar = new Car(selectedColor, DefaultPassengers, DefaultCapacity + extraSeats, DefaultNumberOfTires, DefaultNumberOfWindows, DefaultGasCapacity + extraGasCapacity);
            return deluxeCar;
        }
        #endregion Methods
    }
}
