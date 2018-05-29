using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayOneConsoleAppLogic.Interfaces;

namespace DayOneConsoleAppLogic.Classes.ItemManagement.Inventories
{
    public class NonEquippableInventory: Inventory, IInventory
    {
        public NonEquippableInventory(int heightDimension, int widthDimension):base(heightDimension,widthDimension)
        {
            items = new Item[heightDimension, widthDimension];
        }
    }
}
