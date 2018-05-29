using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic.Interfaces
{
    public interface IInventory
    {
        Item[,] Items { get; }
        //void copyItems(Item[,] existingItems);
        void AdjustWidthDimension(int newWidth);
        void AdjustHeightDimension(int newHeight);
        bool ChangeItem(Item itemToChange, bool addItem);
    }
}
