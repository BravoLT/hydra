using DayOneConsoleAppLogic.Interfaces.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic.Classes.Generics
{
    class NonEquippableInventoryG<NonEquippableItem> : IGenericInventory<NonEquippableItem>
    {
        NonEquippableItem[,] nonEquippableItems;
        public NonEquippableItem[,] Items
        {
            get { return this.nonEquippableItems; }
        }
        public NonEquippableInventoryG(int heightDimension, int widthDimension)
        {
            this.nonEquippableItems = new NonEquippableItem[heightDimension, widthDimension];
        }

        public void AdjustWidthDimension(int newWidth)
        {

        }

        public void AdjustHeightDimension(int newHeight)
        {
        
        }

        public bool ChangeItem(NonEquippableItem item, bool addItem)
        {
            return addItem;
        }


    }
}
