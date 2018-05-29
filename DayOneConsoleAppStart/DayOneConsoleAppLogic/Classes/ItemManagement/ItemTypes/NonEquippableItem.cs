using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public class NonEquippableItem : Item
    {
        public NonEquippableItem(string name, int inventoryWidth, int inventoryHeight) : base(name,inventoryWidth,inventoryHeight)
        {
            
        }
    }
}
