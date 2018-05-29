using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public class Superhero
    {
        private string name = string.Empty;
        private string superpower = string.Empty;
        private int numberOfSidekicks;
        private string city = string.Empty;
        private bool busyFighting = true;

        public Superhero(string name)
        {
            this.Name = name;
        }

        public Superhero(string name, string superpower)
        {
            this.Name = name;
            this.Superpower = superpower;
        }

        public Superhero(string name, string city, int numberOfSidekicks)
        {
            this.Name = name;
            this.City = city;
            this.NumberOfSidekicks = numberOfSidekicks;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Superpower
        {
            get { return superpower; }
            set { superpower = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public int NumberOfSidekicks
        {
            get { return numberOfSidekicks; }
            set { numberOfSidekicks = value; }
        }

        //functions for UsePower and TurnInVillains

        public string UsePower()
        {
            return "POW!!!";
        }

        public int TurnInVillains(int villains)
        {
            return villains;
        }

    }
}
