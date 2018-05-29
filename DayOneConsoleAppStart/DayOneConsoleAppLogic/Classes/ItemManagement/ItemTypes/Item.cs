using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public class Item
    {
        #region privateFields
        private bool pickedUp,placedInInventory = false;
        private string name = string.Empty;
        private int inventoryWidth,inventoryHeight;
        #endregion privateFields

        #region Properties
        public bool PickedUp
        {
            get { return this.pickedUp; }
        }
        public bool PlacedInInventory
        {
            get { return this.placedInInventory; }
        }
        public string Name
        {
            get { return this.name; }
        }
        public int InventoryWidth
        {
            get { return this.inventoryWidth; }
        }
        public int InventoryHeight
        {
            get { return this.inventoryHeight; }
        }
        #endregion Properties

        public Item(string name, int inventoryWidth, int inventoryHeight)
        {
            this.pickedUp = false;
            this.placedInInventory = false;
            this.name = name;
            this.inventoryWidth = inventoryWidth;
            this.inventoryHeight = inventoryHeight;
        }

        #region PublicMethods
        public void SetPickedUp(bool pickedUp)
        {
            this.pickedUp = pickedUp;
        }
        public void SetPlacedInInventory(bool placed)
        {
            this.placedInInventory = placed;
        }
        #endregion PublicMethods
    }
}
