using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public class Tiger: Animal
    {
        public Tiger(string name): base(name)
        {

        }

        public Tiger(string name, float currentWeight): base(name, currentWeight)
        {

        }

        public Tiger(float currentWeight): base(currentWeight)
        {

        }

        public string Prowl()
        {
            return "... ... ... growl";
        }

        //I would like to write a method using a boolean, but would like clarity on what the method would take in... the only thing
        //that makes sense to me would be to use an if statement...

        public string LickingPawsClean(bool LickingPaws)
        {
            if (LickingPaws == true)
            {
                return "The Tiger is currently licking his paws clean";
            }
            else
            {
                return "The Tiger is not licking his paws... LOOKOUT!";
            }
        }
    }
}
