using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
   
    
    // put in specific functionality that the bear, tiger, and lion would have, but not the animal class
    //2 per
    //all the animals chosen are predators... IPredator


    public class Lion: Animal
    {
        private int PrideMembers;

        public Lion(string name) : base(name)
        {

        }

        public Lion(string name, float currentWeight): base(name, currentWeight)
        {

        }

        public Lion(float currentWeight): base(currentWeight)
        {

        }

        public void AcceptLionToPride(int LionsEnteringPride)
        {
            PrideMembers += LionsEnteringPride;
        }

        public int LionsCurrentlyInPride()
        {
            return PrideMembers;
        }

        public string ScareOffHyenas()
        {
            return "ROOOOOOOOOAAARRRRR!!! ***Mufasa voice***";
        }
        
    }
}
