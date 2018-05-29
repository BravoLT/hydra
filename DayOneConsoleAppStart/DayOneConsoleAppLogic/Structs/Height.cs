using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic.Structs
{
    public struct Height
    {
        int feet;
        int inches;

        public Height(int feet, int inches)
        {
            this.feet = feet;
            this.inches = inches;
        }
    }
}
