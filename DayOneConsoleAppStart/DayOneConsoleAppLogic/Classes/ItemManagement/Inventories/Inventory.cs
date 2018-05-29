using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public class Inventory
    {
        #region privateFields
        //private int widthDimension;
        //private int heightDimension;
        protected Item[,] items;
        #endregion privateFields

        #region Properties
        public Item[,] Items
        {
            get { return this.items; }
        }
        #endregion Properties

        #region Constructors
        public Inventory(int heightDimension, int widthDimension)
        {
            //this.widthDimension = widthDimension;
            //this.heightDimension = heightDimension;
            items = new Item[heightDimension, widthDimension];
        }
        #endregion Constructors

        #region PublicMethods
        public void AdjustWidthDimension(int newWidth)
        {
            if (newWidth > this.items.GetLength(1))
            {
                Item[,] existingItems = new Item[this.items.GetLength(0), newWidth];
                //for (int i = 0; i < items.GetLength(0); i++)
                //{
                //    for (int j = 0; j < items.GetLength(1); j++)
                //    {
                //        if (items[i,j] != null)
                //        {
                //            existingItems[i, j] = items[i, j];
                //        }
                //    }
                //}
                this.copyItems(existingItems);
                //this.items = existingItems;
                //this.widthDimension = newWidth;
                //this.items = new Item[this.items.GetLength(0), newWidth];
                //this.items = existingItems;
            }
        }
        protected virtual void copyItems(Item[,] existingItems)
        {
            for (int i = 0; i < items.GetLength(0); i++)
            {
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    if (items[i, j] != null)
                    {
                        existingItems[i, j] = items[i, j];
                    }
                }
            }
            this.items = existingItems;
        }
        public void AdjustHeightDimension(int newHeight)
        {
            if (newHeight > this.items.GetLength(0))
            {
                Item[,] existingItems = new Item[newHeight, this.items.GetLength(1)];
                this.copyItems(existingItems);
            }
        }
        //private bool findItem(Item itemToAccept)
        //{
        //    bool successful = false;

        //    for (int i = 0; i < items.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < items.GetLength(1); j++)
        //        {
        //            if (items[i, j] == null)
        //            {
        //                items[i, j] = itemToAccept;
        //                successful = true;
        //                return successful;
        //            }
        //        }
        //    }
        //    return successful;
       // }
        //private bool moveItem(Item item, bool remove)
        //{
        //    //if we are removing, find and remove
        //    if (remove)
        //    {
        //        return RemoveItem(item);
        //    }
        //    else //we are placing 
        //    {
        //        return AcceptItem(item);
        //    }
        //}


        //public bool AcceptItem(Item itemToAccept)
        //{
        //    return findItem(itemToAccept);
        //}
        //public bool RemoveItem(Item itemToRemove)
        //{
        //    bool successful = false;
        //    for (int i = 0; i < items.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < items.GetLength(1); j++)
        //        {
        //            if (items[i,j] == itemToRemove)
        //            {
        //                items[i, j] = null;
        //                successful = true;
        //                return successful;
        //            }
        //        }
        //    }
        //    return successful;
        //}

        public bool ChangeItem(Item itemToChange, bool addItem)
        {
            bool successful = false;
            for (int i = 0; i < items.GetLength(0); i++)
            {
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    if (addItem)
                    {
                        if (items[i, j] == null)
                        {
                            items[i, j] = itemToChange;
                            successful = true;
                            return successful;
                        }
                    }
                    else
                    {
                        if (items[i, j] == itemToChange)
                        {
                            items[i, j] = null;
                            successful = true;
                            return successful;
                        }
                    }
                }
            }
            return successful;
        }
        #endregion PublicMethods
    }
}
