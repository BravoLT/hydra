using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    //give them function to animal functionality
    //when we inherit it changes how far down we want that access to be
    //**Protected: The class that inherits directly has access, however, anything that inherits from the inheriting class does not
    //Not publicly accessible or modifiable


    public class Bear : Animal
    {
        private string bearFishing = string.Empty;
        private int bearsInsideDen;
        private bool isHibernating = false;

        public Bear(string name):base(name)
        {
            ///this.FoodRequiredToBeFull = 100;

        }

        public Bear(float currentWeight):base(currentWeight)
        {
            
        }

        public Bear(string name, float currentWeight):base(name,currentWeight)
        {

        }

        

        public bool IsHibernating()
        {
            if (this.IsHungry)
            {
                this.isHibernating = false;
            }
            else
            {
                this.isHibernating = true;
            }
            return this.isHibernating;
        }

        public void HowToIfElseIf()
        {
            bool keepRunning = false;

            //1
            if (keepRunning) { }

            //2 
            if (keepRunning) { }
            else { }

            //3
            if (keepRunning)
            {
            }
            else if (!keepRunning)
            {
            }
            else { }

            //4
            if (keepRunning) { }
            else if (keepRunning) { }
            else if (keepRunning) { }
            else { }

            //5
            if (keepRunning) { }
            else if (keepRunning) { }

            int x = 5;
            if (x != 0) { x = 10; }
            else if (x == 0) { x = 5; }
            else if (x > 0) { x = -1; }
            else if (x < 0) { x = 0; }
            else { x = 0; }

            keepRunning = true;
            while (keepRunning)
            {
                if (keepRunning)
                {
                    keepRunning = true;
                    if (keepRunning)
                    {

                        if (keepRunning)
                        {
                            keepRunning = true;
                            if (keepRunning)
                            {

                            }
                        }
                        else
                        {
                            if (keepRunning)
                            {
                                keepRunning = true ? false : true;
                            }
                        }
                        keepRunning = true;
                    }
                    else if (keepRunning)
                    {
                        if (keepRunning)
                        {
                            keepRunning = false;
                        }
                    }
                    else
                    {
                        keepRunning = true;
                        if (keepRunning)
                        {
                            keepRunning = true;
                        }
                    }
                }
            }
            x = 4;


            
        }

        private bool HowIMakeIf()
        {
            bool successful = false;

            if (1 == 0)
            {
                successful = true;
            }
            else if (1 == 1)
            {
                return successful ;
            }
            else
            {
                successful = true;
            }

            return successful;
        }

        public string GoneFishing(string bearFishing)
        {
            if (bearFishing == "yes")
            { return "The bear is out fishing"; }

            else { return "The bear is not fishing"; }

        }

        public int BearsInDen()
        {
            return bearsInsideDen;
        }

        public void bearEnterDen(int enteringBears)
        {
            bearsInsideDen += enteringBears;
        }



    }


}
