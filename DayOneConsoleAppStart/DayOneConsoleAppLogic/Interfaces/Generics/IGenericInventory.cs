using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic.Interfaces.Generics
{
    interface IGenericInventory<T>
    {
        T[,] Items { get; }
        void AdjustWidthDimension(int newWidth);
        void AdjustHeightDimension(int newHeight);
        bool ChangeItem(T itemToChange, bool addItem);
    }
}
