using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    /*
     * Create an abstract base class
     * create concrete class that inherits the base class
     * create overrideable functionality
     * what i come up with needs to have a constructor that takes in a lot of parameters and maps them
     * redo animal so they inherit but abstractly
     * create a unit test
     */
    public class Car: Vehicle
    {
        //private int carMaxOccupancy()
        //{
        //    maxOccupancy = 4;
        //    return maxOccupancy;
        //}
        //public Car(string color, int numberOfPassengers , int maxCapacity, int numberOfWheels, int numberOfWindows, float fuelCapacity)// : base()
        //{
        //    this.color = color;
        //    this.numberOfPassengers = numberOfPassengers;
        //    this.maxOccupancy = maxCapacity;
        //    this.numberOfWheels = numberOfWheels;
        //    this.numberOfWindows = numberOfWindows;
        //    this.fuelCapacity = fuelCapacity;
        //}

        public Car(string color, int numberOfPassengers, int maxCapacity, int numberOfWheels, int numberOfWindows, float fuelCapacity) 
            :base(color, numberOfPassengers,maxCapacity,numberOfWheels,numberOfWindows,fuelCapacity)
        {
            this.color = color;
            this.numberOfPassengers = numberOfPassengers;
            this.maxOccupancy = maxCapacity;
            this.numberOfWheels = numberOfWheels;
            this.numberOfWindows = numberOfWindows;
            this.fuelCapacity = fuelCapacity;
        }

        //public override void AcceptPassenger(int numberOfPassengers)
        //{
        //    base.AcceptPassenger(numberOfPassengers);
        //}

        public override string ToString()
        {
            string info =
                string.Format("The car is {0} with {1} people inside currently.  The car has capacity for {2} passengers, has {3} wheels, {4} windows, and a {5} gallon tank."
                , this.color, this.numberOfPassengers, this.maxOccupancy, this.numberOfWheels, this.numberOfWindows, this.fuelCapacity);
            return info;
        }
    }
}
