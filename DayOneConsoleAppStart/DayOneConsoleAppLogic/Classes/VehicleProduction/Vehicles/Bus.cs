using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public class Bus : Vehicle
    {
        public Bus(string color, int numberOfPassengers, int maxCapacity, int numberOfWheels, int numberOfWindows, float fuelCapacity)
            : base(color, numberOfPassengers, maxCapacity, numberOfWheels, numberOfWindows, fuelCapacity)
        {
            this.color = color;
            this.numberOfPassengers = numberOfPassengers;
            this.maxOccupancy = maxCapacity;
            this.numberOfWheels = numberOfWheels;
            this.numberOfWindows = numberOfWindows;
            this.fuelCapacity = fuelCapacity;
        }
    }
}
