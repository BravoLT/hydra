using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public class Garage
    {
        private int numberOfStalls;
        private bool isFull = false;
        private int currentVehicles;
        Vehicle[] carHoles;

        public bool IsFull
        {
            get
            {
                this.isFull = numberOfStalls == currentVehicles;
                return this.isFull;
            }
        }

        public Garage(int numberOfStalls)
        {
            this.numberOfStalls = numberOfStalls;
            carHoles = new Vehicle[this.numberOfStalls];
        }

        public void AcceptVehicleInGarage(Vehicle vehicleToAccept)
        {
            if (isFull == false)
            {
                int i = 0;
                while (i < this.numberOfStalls)
                {
                    if (carHoles[i] == null)
                    {
                        carHoles[i] = vehicleToAccept;
                        i = this.numberOfStalls;
                    }
                    i++;
                }
            }
        }

        public Vehicle[] Vehicles
        {
            get { return this.carHoles; }
        }
    }
}
