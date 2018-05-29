using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public abstract class Vehicle
    {
        #region privateFields
        protected int numberOfDoors;
        protected float fuelCapacity;
        protected float fuelInVehicle;
        protected string color = string.Empty;
        protected int numberOfWheels;
        protected int numberOfWindows;
        protected bool hasEngine = false;
        protected int maxOccupancy = 12;
        protected int numberOfPassengers = 6;
        #endregion privateFields
        #region Properties
        public string Color
        {
            get { return this.color; }
        }
        public int NumberOfPassengers
        {
            get { return this.numberOfPassengers; }
            set { this.numberOfPassengers = value; }
        }
        public int MaxCapacity
        {
            get { return this.maxOccupancy; }
        }
        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }
        public int NumberOfWindows
        {
            get { return this.numberOfWindows; }
        }
        public float FuelCapacity
        {
            get { return this.fuelCapacity; }
        }
        #endregion Properties
        #region Constructors
        public Vehicle(string color, int numberOfPassengers, int maxCapacity, int numberOfWheels, int numberOfWindows, float fuelCapacity)// : base()
        {
            this.color = color;
            this.numberOfPassengers = numberOfPassengers;
            this.maxOccupancy = maxCapacity;
            this.numberOfWheels = numberOfWheels;
            this.numberOfWindows = numberOfWindows;
            this.fuelCapacity = fuelCapacity;
        }
            #endregion Constructors
            #region PublicMethods
            public void Travel()
        {

        }
        
        public Vehicle()
        {

        }

        public virtual void AcceptPassenger(int numberOfPassengers)
        {
            int difference = this.maxOccupancy - this.numberOfPassengers;

            int dummy = 0;
            dummy = this.numberOfPassengers + numberOfPassengers;

            if (dummy > this.maxOccupancy)
            {
                difference = dummy -this.maxOccupancy;
                this.numberOfPassengers += difference;
            }
            else
            {
                this.numberOfPassengers = dummy;
            }
        }

        public virtual int NumPassengers()
        {
            return this.numberOfPassengers;
        }
        #endregion PublicMethods
        #region privateMethods
        #endregion privateMethods
    }
}
