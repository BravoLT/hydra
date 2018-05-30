using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public abstract class Animal
    {
        #region privateFields
        protected string name = string.Empty;
        protected float currentWeight;
        protected float currentHeight;
        protected string location = string.Empty;
        protected bool isHungry = true;
        protected string animalNoise = string.Empty;
        protected bool isAsleep = true;
        protected int daysOld;
        protected int foodRequiredToBeFull = 0;
        #endregion privateFields

        //GET/SET Name or string GetName(), void SetName(string name)
        public string Name
        {
            //get;
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Public method that takes in an int currentHunger and uses the animals currentWeight to calculate the amount of food required to be full
        /// </summary>
        /// <param name="currentHunger">int value about the current hunger out of ten</param>
        public void CalculateFoodAmount(int currentHunger)
        {
            if (currentHunger != 0 && currentHunger < currentWeight)
            {
                this.foodRequiredToBeFull =
                    (int)((currentHunger / this.CurrentWeight) + this.CurrentWeight - currentHunger * .8);
            }
            else if ((currentHunger != 0 && currentHunger > CurrentWeight) || (currentHunger/CurrentWeight < 2))
            {
                this.foodRequiredToBeFull = (int)((currentHunger / this.CurrentWeight));
            }
            else
            {
                this.foodRequiredToBeFull = 0;
            }
        }
        public int FoodRequiredToBeFull
        {
            get { return this.foodRequiredToBeFull; }
            set { this.foodRequiredToBeFull = value; }
        }

        protected bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

       

        protected static string color;

        public static string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string GetMyAnimalColor()
        {
            string tempColor = string.Empty;
            tempColor = Color;
            return tempColor;
        }

        public float CurrentWeight
        {
            get { return currentWeight; }
            set { currentWeight = value; }
        }

        public Animal(string name)
        {
            this.Name = name;
        }   

        public Animal(float currentWeight)
        {
            this.currentWeight = currentWeight;
        }

        public Animal(string name, float currentWeight)
        {
            this.Name = name;
            this.CurrentWeight = currentWeight;
        }

        public bool Eat(int foodAmount)
        {
            this.isHungry = false;
            return this.isHungry;
        }

        private string eat()
        {

            return string.Empty;
        }

        public string Sleep()
        {
            return sleep();
        }

        public void GetOlder()
        {
            //int daysOld = 0;
            //int newDaysOld;
            this.daysOld += 1;
            //newDaysOld = daysOld;
           // return this.daysOld;
            

        }

        public int GetDayzOld()
        {
            return this.daysOld;
        }
        public void SetDays(int days)
        {
            this.daysOld = days;
        }


        public int DayzOld
        {
            get { return this.daysOld; }
            set { this.daysOld = value; }
        }

        private string sleep()
        {
            return string.Empty;
        }

        public string MakeNoise()
        {
            return makeNoise();
        }

        private string makeNoise()
        {
            return string.Empty;
        }

        private void poop()
        {

        }

        public void Update(string name, int num)
        {
            //take in string and num and then manipulate internal array and or matrix to shift based on values

        }

        public override string ToString()
        {
            string animalStuff = string.Format("The name of the animal is a {0} and weighs {1} pounds. {0} is a {2}", this.name, this.currentWeight,this.GetType().ToString().Split('.')[1].ToLower());
            return animalStuff;
        }

    }
}
