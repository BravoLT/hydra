using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic.Classes.GeneralUse
{
    public class Height
    {
        private int feet;
        private int inches;

        public int Feet
        {
            get { return this.feet; }
        }
        public int Inches
        {
            get { return this.inches; }
        }

        public Height(int feet, int inches)
        {
            this.feet = feet;
            this.inches = inches;
            
        }

    }
}
