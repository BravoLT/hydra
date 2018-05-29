using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
   

   /*Store an array of villains (in the jail class... duh)
    * villains needs a boolean property about being fed, that can be flipped
    * have a way to take in villains
    * how and where we can add in villains into the array
    * what should the size of the villain array be?
    * need to have a public property to get the array of villains, but not set them
    * have a way to accept in villains (keep old, but still make new)
    * create a class called "Garage" that can store an array of vehicles.
    * create more vehicles (truck, motorcycle,... etc)
    * */
       
        
    public class Jail
    {
        public int numOfVillains;
        private static int jailCapacity = 130;
        private bool jailAtCapacity = false;
        private bool villainFed = false;
        private Villain[] arrayForJail = new Villain[jailCapacity];

        /// <summary>
        /// A function that takes in a villain and stores it in the Jail's Villain[]
        /// </summary>
        /// <param name="VillainToAdd">the villain that we want to add</param>
        public void PlaceVillain(Villain VillainToAdd)
        {
            for (int i = 0; i < jailCapacity; i++)
            {
                if (i < arrayForJail.Length)
                {
                    if (arrayForJail[i] == null)
                    {
                        arrayForJail[i] = VillainToAdd;
                        i = jailCapacity;
                    }
                }
               
            }

        }

        public Villain[] ArrayForJail
        {
            get { return this.arrayForJail; }
        }
        

        public int villainCount()
        {
            
            //villains = numOfVillains + villains;
            return numOfVillains;
        }

        public int acceptVillains(int villains, string heroName)
        {
            //this method will take in the number of villains that are turned in as well as the last superhero who caught the baddies
            numOfVillains += villains;
            heroName = heroName;
            return numOfVillains;
        }

        public void TakeInProcess(Villain villainToBeProcessed, int weight, string height)
        {
            villainToBeProcessed.SetWeight(weight);
            villainToBeProcessed.SetHeight(height);
        }

    }
}
