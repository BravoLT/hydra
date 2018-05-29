using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public class Villain
    {
        #region privateFields
        private string 
            name,
            evilPower,
            emblem,
            primaryColor,
            secondaryColor,
            height 
            = string.Empty;

        private bool isHungry = false;

        private int 
            foodNecessary,
            weight;
        #endregion privateFields

        #region properties
        public string Name
        {
            get { return this.name; }
        }
        public string EvilPower
        {
            get { return this.evilPower; }
        }
        public string Emblem
        {
            get { return this.emblem; }
        }
        public string PrimaryColor
        {
            get { return this.primaryColor; }
        }
        public string SecondaryColor
        {
            get { return this.secondaryColor; }
        }
        public int Weight
        {
            get { return this.weight; }
        }
        public string Height
        {
            get { return this.height; }
        }
        public bool IsHungry
        {
            get { return this.isHungry; }
        }
        #endregion properties



        public Villain(string name, string evilPower, string emblem, string primaryColor, string secondaryColor)
        {
            this.name = name;
            this.evilPower = evilPower;
            this.emblem = emblem;
            this.primaryColor = primaryColor;
            this.secondaryColor = secondaryColor;
            Random randomizer = new Random(3);
            this.weight = randomizer.Next(150, 300 + (randomizer.Next(0,3) + 1) *1);
            int feet = randomizer.Next(1, 8);
            int inches = randomizer.Next(0, 12);
            //Random weightRandomizer = new Random(50);
            //this.weight = weightRandomizer.Next(150, 300);
            //Random footRandomizer = new Random(3);
            //feet = footRandomizer.Next(1, 8);
            //Random inchRandomizer = new Random(9);
            //inches = inchRandomizer.Next(0, 12);
            this.height = string.Format("{0}\' {1}\'\'",feet,inches);
            this.foodNecessary = (int)(this.weight * .02f);
            
        }

        public string DoEvil(int victims, string location, string weaponUsed, string crimeCommitted)
        {
            string description = string.Format("{0} is well known to be wearing {1} and {2}. Their emblem is a(n) {3}, and have the ability to {4}.",
                this.name,this.primaryColor,this.secondaryColor,this.emblem,this.evilPower);

            return string.Format("{0} committed {1} at {2}. {3} victims were affected, and {0} used a(n) {4}. {5}",
                this.name, crimeCommitted, location, victims, weaponUsed, description);
        }

        public void SetHunger(int foodNecessary)
        {
            
        }

        public void SetWeight(int newWeight)
        {
            if (newWeight > 0)
            {
                this.weight = newWeight;
            }
        }

        public void SetHeight(string newHeight)
        {
            this.height = newHeight;
        }

        public bool Eat(int foodAmount)
        {
            if (foodAmount > foodNecessary)
            {
                isHungry = false;
            }
            else
            {
                isHungry = true;
            }
            return isHungry;
        }

    }
}
